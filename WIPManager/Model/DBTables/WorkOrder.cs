using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WIPManager.Utils;

namespace WIPManager.Model

{
    class WorkOrder
    {
        #region Events

        public event Action Cleared;
        public event Action Changed;

        #endregion

        #region Constants

        private const string RecordIDCol = "RECORD_IDENTITY";
        private const string WorkIDCol = "WORK_ID";
        private const string LotIDCol = "LOT_ID";
        private const string SplitIDCol = "SPLIT_ID";
        private const string PartIDCol = "PART_ID";
        private const string DescriptionCol = "DESCRIPTION";
        private const string OrderStatusCol = "ORDER_STATUS";
        private const string ReleaseDateCol = "DESIRED_RLS_DATE";
        private const string CloseDateCol = "CLOSED_DATE";
        private const string DesiredQtyCol = "DESIRED_QTY";
        private const string ReceivedQtyCol = "RECEIVED_QTY";
        private const string WipLocationCol = "USER_1";
        private const string KittedByCol = "USER_2";
        private const string KittingStatusCol = "USER_3";
        private const string WipUserCol = "USER_4";
        private const string WipDateCol = "USER_5";

        #endregion

        #region Data Members

        private SQLConnection _sqlCon = new SQLConnection();
        private Logger _log;

        #endregion

        #region Properties

        public DBString RecordID = new DBString(RecordIDCol);
        public DBString WorkID = new DBString(WorkIDCol);
        public DBString LotID = new DBString(LotIDCol);
        public DBString SplitID = new DBString(SplitIDCol);
        public DBString PartID = new DBString(PartIDCol);
        public DBString Description = new DBString(DescriptionCol);
        public DBString OrderStatus = new DBString(OrderStatusCol);
        public DBDate ReleaseDate = new DBDate(ReleaseDateCol);
        public DBDate CloseDate = new DBDate(CloseDateCol);
        public DBDecimal DesiredQty = new DBDecimal(DesiredQtyCol);
        public DBDecimal ReceivedQty = new DBDecimal(ReceivedQtyCol);

        public DBString WipLocation = new DBString(WipLocationCol);
        public DBString KittedByUserID = new DBString(KittedByCol);
        public DBString KittingStatus = new DBString(KittingStatusCol);
        public DBString WipUserID = new DBString(WipUserCol);
        public DBString WipDate = new DBString(WipDateCol);

        public List<Material> Materials = new List<Material>();

        #endregion

        #region Public Functions

        public WorkOrder(Logger log)
        {
            _log = log;
        }

        public void UpdateKittingStatus()
        {
            string status = "NONE";

            if (Materials.Count > 0)
            {
                int totalClosedMaterials = 0;
                int totalMaterials = 0;
                double totalIssuedQty = 0;
                double totalCalcdQty = 0;

                foreach (var material in Materials)
                {
                    totalMaterials++;
                    totalCalcdQty += material.CalqQty;

                    if (material.MaterialStatus == "CLOSED")
                    {
                        totalClosedMaterials++;
                    }

                    totalIssuedQty += material.IssuedQty;
                }
                if (totalMaterials == totalClosedMaterials)
                    status = "COMPLETE";
                else if (totalIssuedQty == 0)
                    status = "NONE";
                else
                    status = "INCOMPLETE";
            }

            KittingStatus.Value = status;
        }

        public bool ReadFromRecordId(string uniqueRecordId)
        {
            RecordID.Value = uniqueRecordId;
            Operation operation;

            if (GetOperationInfo(uniqueRecordId, out operation))
            {
                SetValuesFromOperation(operation);

                if (GetWOInfo())
                {
                    Changed?.Invoke();
                    return true;
                }
            }

            // If we get here, read did not succeed.  Clear data.
            Clear();
            return false;
        }

        public bool ReadFromWorkOrderId(string workOrderId)
        {
            WorkID.Value = workOrderId;

            if (GetWOInfo())
            {
                Changed?.Invoke();
                return true;
            }

            Clear();
            return false;
        }

        public bool Write()
        {
            bool retVal = false;

            string cmdString = "UPDATE dbo.SHOPFLOOR_WORK_ORDER ";
            cmdString += "SET USER_1 = @WIPLocation, ";
            cmdString += "USER_2 = @KittingUserID, ";
            cmdString += "USER_3 = @KittingStatus, ";
            cmdString += "USER_4 = @WipUserID, ";
            cmdString += "USER_5 = @WIPDate ";
            cmdString += "WHERE RECORD_IDENTITY = @RecordID";

            try
            {
                _sqlCon.OpenVJSConnection();

                using (_sqlCon.VJSCon)
                {
                    if (_sqlCon.VJSCon.State != ConnectionState.Open)
                    {
                        _sqlCon.VJSCon.Open();
                    }

                    SqlCommand newCmd = new SqlCommand(cmdString, _sqlCon.VJSCon);
                    newCmd.Parameters.AddWithValue("@RecordID", RecordID);
                    newCmd.Parameters.AddWithValue("@WIPLocation", WipLocation);
                    newCmd.Parameters.AddWithValue("@KittingUserID", KittedByUserID);
                    newCmd.Parameters.AddWithValue("@KittingStatus", KittingStatus);
                    newCmd.Parameters.AddWithValue("@WipUserID", WipUserID);
                    newCmd.Parameters.AddWithValue("@WIPDate", WipDate);
                    int nUpdateCount = newCmd.ExecuteNonQuery();
                    retVal = nUpdateCount > 0;
                }
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, "WO", "Exception writing WO: " + ex.Message);
            }

            foreach (var material in Materials)
            {
                retVal &= material.Write();
            }

            return retVal;
        }

        public void Reload()
        {
            if (GetWOInfo())
            {
                Changed?.Invoke();
            }
            else
            {
                Clear();
            }
        }

        public void Clear()
        {
            RecordID.Clear();
            WorkID.Clear();
            LotID.Clear();
            SplitID.Clear();
            PartID.Clear();
            Description.Clear();
            OrderStatus.Clear();
            ReleaseDate.Clear();
            CloseDate.Clear();
            DesiredQty.Clear();
            ReceivedQty.Clear();

            WipLocation.Clear();
            KittedByUserID.Clear();
            KittingStatus.Clear();
            WipUserID.Clear();
            WipDate.Clear();

            Materials.Clear();

            Cleared?.Invoke();
        }

        #endregion

        #region Private Functions

        private bool GetOperationInfo(string recordID, out Operation operation)
        {
            bool retVal = false;
            operation = null;

            string tableName = "dbo.SHOPFLOOR_OPERATION";
            string columnSelect = "SELECT * ";
            string searchColumn = RecordIDCol;
            string searchCriteria = recordID;

            try
            {
                _sqlCon.OpenVJSConnection();

                using (_sqlCon.VJSCon)
                {
                    string cmdString = "";
                    if (_sqlCon.VJSCon.State != ConnectionState.Open)
                        _sqlCon.VJSCon.Open();
                    cmdString = columnSelect + string.Format("FROM {0} WHERE {1} = '{2}'", tableName, searchColumn, searchCriteria);
                    SqlCommand newCmd = new SqlCommand(cmdString, _sqlCon.VJSCon);
                    using (newCmd)
                    {
                        var reader = newCmd.ExecuteReader();
                        var dtOperation = new DataTable();
                        dtOperation.Load(reader);
                        dtOperation.DefaultView.Sort = "RECORD_IDENTITY ASC";
                        dtOperation = dtOperation.DefaultView.ToTable();

                        if (dtOperation.Rows.Count > 0)
                        {
                            operation = new Operation(_log, dtOperation.Rows[0]);
                            retVal = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, "WO", "Exception reading Operation table for WO: " + ex.Message);
            }

            return retVal;
        }

        private bool GetWOInfo()
        {
            bool retVal = false;
            string tableName = "dbo.SHOPFLOOR_WORK_ORDER";
            string columnSelect = "SELECT * ";

            string recordIdConnStr = columnSelect + "FROM " + tableName + " WHERE WORK_ID = '{0}' AND LOT_ID = '{1}' AND SPLIT_ID = '{2}'";
            string workIdConnStr = columnSelect + "FROM " + tableName + " WHERE WORK_ID = '{0}'";
            string cmdString = "";

            if (string.IsNullOrEmpty(WorkID.Value))
            {
                return false;
            }

            try
            {
                _sqlCon.OpenVJSConnection();
                using (_sqlCon.VJSCon)
                {
                    if (_sqlCon.VJSCon.State != ConnectionState.Open)
                    {
                        _sqlCon.VJSCon.Open();
                    }

                    if (string.IsNullOrEmpty(LotID.Value) || string.IsNullOrEmpty(SplitID.Value))
                    {
                        cmdString = string.Format(workIdConnStr, WorkID);
                    }
                    else
                    {
                        cmdString = string.Format(recordIdConnStr, WorkID, LotID, SplitID);
                    }

                    SqlCommand newCmd = new SqlCommand(cmdString, _sqlCon.VJSCon);
                    using (newCmd)
                    {
                        var reader = newCmd.ExecuteReader();
                        var dtWorkOrders = new DataTable();
                        dtWorkOrders.Load(reader);

                        if (dtWorkOrders.Rows.Count > 0)
                        {
                            dtWorkOrders.DefaultView.Sort = "WORK_ID ASC";
                            dtWorkOrders = dtWorkOrders.DefaultView.ToTable();

                            Update(dtWorkOrders.Rows[0]);
                            retVal = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, "WO", "Exception reading WO Info: " + ex.Message);
            }

            return retVal;
        }

        private bool GetMaterials()
        {
            DataTable dtMaterials;
            string tableName = "dbo.SHOPFLOOR_MATERIAL";
            string columnSelect = "SELECT * ";

            try
            {
                _sqlCon.OpenVJSConnection();

                using (_sqlCon.VJSCon)
                {
                    string cmdString = "";
                    if (_sqlCon.VJSCon.State != ConnectionState.Open)
                        _sqlCon.VJSCon.Open();
                    cmdString = columnSelect + string.Format("FROM {0} WHERE WORK_ID = '{1}' AND LOT_ID = '{2}'", tableName, WorkID, LotID);
                    SqlCommand newCmd = new SqlCommand(cmdString, _sqlCon.VJSCon);

                    using (newCmd)
                    {
                        var reader = newCmd.ExecuteReader();
                        dtMaterials = new DataTable();
                        dtMaterials.Load(reader);
                        dtMaterials.DefaultView.Sort = "SEQ_NO,PIECE_NO ASC";
                        dtMaterials = dtMaterials.DefaultView.ToTable();
                    }

                    AddMaterialsFromDataTable(dtMaterials);
                }
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, "WO", "Exception reading material table: " + ex.Message);
            }

            return true;
        }

        private void Update(DataRow row)
        {
            Clear();

            RecordID.ReadValueFromRow(row);
            WorkID.ReadValueFromRow(row);
            LotID.ReadValueFromRow(row);
            SplitID.ReadValueFromRow(row);
            PartID.ReadValueFromRow(row);
            Description.ReadValueFromRow(row);
            OrderStatus.ReadValueFromRow(row);
            ReleaseDate.ReadValueFromRow(row);
            CloseDate.ReadValueFromRow(row);
            DesiredQty.ReadValueFromRow(row);
            ReceivedQty.ReadValueFromRow(row);
            WipLocation.ReadValueFromRow(row);
            KittedByUserID.ReadValueFromRow(row);
            KittingStatus.ReadValueFromRow(row);
            WipUserID.ReadValueFromRow(row);
            WipDate.ReadValueFromRow(row);

            GetMaterials();
            UpdateKittingStatus();
        }

        internal void UpdateWipLocationFromMaterials()
        {
            HashSet<string> locations = new HashSet<string>();

            foreach (var material in Materials)
            {
                LocationString locStr = new LocationString(material.Locations);
                locations.UnionWith(locStr.Locations);
            }

            string finalStr = "";

            foreach (var entry in locations)
            {
                if (finalStr.Length > 0)
                {
                    finalStr += ",";
                }

                finalStr += entry;
            }

            WipLocation.Value = finalStr;
        }

        private void AddMaterialsFromDataTable(DataTable tableMaterials)
        {
            Materials.Clear();

            foreach (DataRow dataRow in tableMaterials.Rows)
            {
                Materials.Add(new Material(dataRow, _log));
            }
        }

        private void SetValuesFromOperation(Operation operation)
        {
            WorkID.Value = operation.WorkID.Value;
            LotID.Value = operation.LotID.Value;
            SplitID.Value = operation.SplitID.Value;
        }

        private string GetStringFromColumnName(DataRow row, string colName)
        {
            string field = row.Field<string>(colName);
            return field is null ? "" : field;
        }

        private string GetDateFromColumnName(DataRow row, string colName)
        {
            return string.Format("{0:MM/dd/yyyy}", row.Field<DateTime?>(colName));
        }

        private string GetNumberFromColumnName(DataRow row, string colName)
        {
            decimal num = row.Field<decimal>(colName);
            return num.ToString();
        }

        #endregion
    }
}
