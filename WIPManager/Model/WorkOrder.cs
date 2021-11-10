using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIPManager.Utils;

namespace WIPManager
{
    class WorkOrder
    {
        #region Events

        public event Action Cleared;
        public event Action Changed;

        #endregion

        #region Data Members

        private SQLCon _sqlCon = null;
        private Logger _log;

        #endregion

        #region Properties

        public string RecordId;
        public string WorkID;
        public string LotID;
        public string SplitID;
        public string SubID;
        public string SeqNO;
        public string PartId;
        public string Description;
        public string OrderStatus;
        public string ReleaseDate;
        public string CloseDate;
        public string DesiredQty;
        public string ReceivedQty;

        public string AssemblyStatus; //USER_0
        public string WipLocation; //USER_1
        public string KittedByUserID; //USER_2
        public string KittingStatus; //USER_3
        public string WipUserID; //USER_4
        public string WipDate; //USER_5

        public List<Material> Materials = new List<Material>();

        #endregion

        #region Public Functions

        public WorkOrder(Logger log)
        {
            _log = log;
            _sqlCon = new SQLCon(_log);
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

            KittingStatus = status;
        }

        public bool ReadFromRecordId(string uniqueRecordId)
        {
            RecordId = uniqueRecordId;

            if (GetOperationInfo(uniqueRecordId))
            {
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
            WorkID = workOrderId;

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
                    newCmd.Parameters.AddWithValue("@RecordID", RecordId);
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
            RecordId = "";
            WorkID = "";
            LotID = "";
            SplitID = "";
            SubID = "";
            SeqNO = "";
            PartId = "";
            Description = "";
            OrderStatus = "";
            ReleaseDate = "";
            CloseDate = "";
            DesiredQty = "";
            ReceivedQty = "";

            AssemblyStatus = "";
            WipLocation = "";
            KittedByUserID = "";
            KittingStatus = "";
            WipUserID = "";
            WipDate = "";

            Materials.Clear();

            Cleared?.Invoke();
        }

        #endregion

        #region Private Functions

        private bool GetOperationInfo(string recordID)
        {
            bool retVal = false;
            string tableName = "dbo.SHOPFLOOR_OPERATION";
            string columnSelect = "SELECT * ";
            string searchColumn = "RECORD_IDENTITY";
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
                            WorkID = dtOperation.Rows[0].ItemArray[5].ToString();
                            LotID = dtOperation.Rows[0].ItemArray[6].ToString();
                            SplitID = dtOperation.Rows[0].ItemArray[7].ToString();
                            SubID = dtOperation.Rows[0].ItemArray[8].ToString();
                            SeqNO = dtOperation.Rows[0].ItemArray[9].ToString();
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

            if (string.IsNullOrEmpty(WorkID))
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

                    if (string.IsNullOrEmpty(LotID) || string.IsNullOrEmpty(SplitID))
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

            RecordId = row.ItemArray[0].ToString();
            WorkID = row.ItemArray[5].ToString();
            LotID = row.ItemArray[6].ToString();
            SplitID = row.ItemArray[7].ToString();
            PartId = row.ItemArray[9].ToString();
            Description = row.ItemArray[10].ToString();
            OrderStatus = row.ItemArray[41].ToString();
            ReleaseDate = string.Format("{0:MM/dd/yyyy}", row.ItemArray[36]);
            CloseDate = string.Format("{0:MM/dd/yyyy}", row.ItemArray[39]);
            DesiredQty = row.ItemArray[12].ToString();
            ReceivedQty = row.ItemArray[38].ToString();
            WipLocation = row.ItemArray[59].ToString();
            KittedByUserID = row.ItemArray[60].ToString();
            KittingStatus = row.ItemArray[61].ToString();
            WipUserID = row.ItemArray[62].ToString();
            WipDate = row.ItemArray[63].ToString();
            GetMaterials();
            UpdateKittingStatus();

            //TODO: Fields not yet used
            //labelEngineeringRev.Text = dt.Rows[thisLot].ItemArray[35].ToString();
            //labelCommodityCode.Text = dt.Rows[thisLot].ItemArray[20].ToString();
            //labelEngineeredBy.Text = dt.Rows[thisLot].ItemArray[13].ToString();
            //labelGlobalRank.Text = dt.Rows[thisLot].ItemArray[11].ToString();
            //labelDrawingFile.Text = dt.Rows[thisLot].ItemArray[17].ToString();
            //labelCreatedDate.Text = dt.Rows[thisLot].ItemArray[1].ToString();
            //labelModifiedBy.Text = dt.Rows[thisLot].ItemArray[3].ToString();
            //labelModifiedDate.Text = dt.Rows[thisLot].ItemArray[2].ToString();
            //labelWantDate.Text = string.Format("{0:MM/dd/yyyy}", dt.Rows[thisLot].ItemArray[37]);
            //labelScheduledStart.Text = string.Format("{0:MM/dd/yyyy}", dt.Rows[thisLot].ItemArray[52]);
            //labelScheduledFinish.Text = string.Format("{0:MM/dd/yyyy}", dt.Rows[thisLot].ItemArray[53]);
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

            this.WipLocation = finalStr;
        }

        private void AddMaterialsFromDataTable(DataTable tableMaterials)
        {
            Materials.Clear();

            foreach (DataRow dataRow in tableMaterials.Rows)
            {
                Materials.Add(new Material(dataRow, _log));
            }
        }

        #endregion
    }
}
