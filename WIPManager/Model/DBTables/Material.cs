using System;
using System.Data;
using System.Data.SqlClient;
using WIPManager.Utils;

namespace WIPManager.Model
{
    class Material
    {
        public string RecordNumber;
        public string PieceNO;
        public string PartNO;
        public string Description;
        public double CalqQty;
        public double IssuedQty;
        public string QtyPer;
        public string MaterialStatus;

        public string AssemblyStatus;   // USER_0
        public string Locations;        // USER_1
        public string KittedBy;         // USER_2
        public string KittingStatus;    // USER_3
        public string WipPullReturnBy;  // USER_4
        public string WipPullReturnDate;// USER_5

        #region Data Members

        private SQLConnection _sqlCon = new SQLConnection();
        private Logger _log;

        #endregion

        public Material (DataRow row, Logger log)
        {
            _log = log;

            RecordNumber = row.ItemArray[0].ToString();
            PieceNO = row.ItemArray[11].ToString();
            PartNO = row.ItemArray[20].ToString();
            Description = row.ItemArray[22].ToString();
            QtyPer = row.ItemArray[24].ToString();
            MaterialStatus = row.ItemArray[16].ToString();

            AssemblyStatus = row.ItemArray[73].ToString();
            Locations = row.ItemArray[74].ToString();
            KittedBy = row.ItemArray[75].ToString();
            KittingStatus = row.ItemArray[76].ToString();
            WipPullReturnBy = row.ItemArray[77].ToString();
            WipPullReturnDate = row.ItemArray[78].ToString();

            string calcStr = row.ItemArray[33].ToString();

            CalqQty = 0;
            Double.TryParse(calcStr, out CalqQty);

            string issStr = row.ItemArray[17].ToString();
            IssuedQty = 0;
            Double.TryParse(issStr, out IssuedQty);
        }

        public bool Write()
        {
            //TODO: Add more types of writes?
            bool retVal = false;

            try
            {
                string cmdString = "UPDATE dbo.SHOPFLOOR_MATERIAL ";
                cmdString += "SET USER_1 = @WIPLocation, ";
                cmdString += "USER_2 = @KittingUserID, ";
                cmdString += "USER_4 = @WipUserID, ";
                cmdString += "USER_5 = @WIPDate ";
                cmdString += "WHERE RECORD_IDENTITY = @RecordID";

                _sqlCon.OpenVJSConnection();

                using (_sqlCon.VJSCon)
                {
                    if (_sqlCon.VJSCon.State != ConnectionState.Open)
                        _sqlCon.VJSCon.Open();

                    SqlCommand newCmd = new SqlCommand(cmdString, _sqlCon.VJSCon);
                    newCmd.Parameters.AddWithValue("@RecordID", RecordNumber);
                    newCmd.Parameters.AddWithValue("@WIPLocation", Locations);
                    newCmd.Parameters.AddWithValue("@KittingUserID", KittedBy);
                    newCmd.Parameters.AddWithValue("@WipUserID", WipPullReturnBy);
                    newCmd.Parameters.AddWithValue("@WIPDate", WipPullReturnDate);
                    int nUpdateCount = newCmd.ExecuteNonQuery();
                    retVal = nUpdateCount > 0;
                }
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, "MATERIAL", "Exception writing material: " + ex.Message);
            }

            return retVal;
        }


    }
}
