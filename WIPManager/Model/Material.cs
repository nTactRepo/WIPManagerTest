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

        private Logger _log;

        #endregion

        public Material (DataRow row, Logger log)
        {
            _log = log;

            RecordNumber = row.ItemArray[0].ToString();
            PieceNO = row.ItemArray[10].ToString();
            PartNO = row.ItemArray[19].ToString();
            Description = row.ItemArray[21].ToString();
            QtyPer = row.ItemArray[23].ToString();
            MaterialStatus = row.ItemArray[15].ToString();

            AssemblyStatus = row.ItemArray[72].ToString();
            Locations = row.ItemArray[73].ToString();
            KittedBy = row.ItemArray[74].ToString();
            KittingStatus = row.ItemArray[75].ToString();
            WipPullReturnBy = row.ItemArray[76].ToString();
            WipPullReturnDate = row.ItemArray[77].ToString();

            string calcStr = row.ItemArray[32].ToString();

            CalqQty = 0;
            Double.TryParse(calcStr, out CalqQty);

            string issStr = row.ItemArray[16].ToString();
            IssuedQty = 0;
            Double.TryParse(issStr, out IssuedQty);
        }

        public bool Write()
        {
            bool retVal = false;

            try
            {
                string cmdString = "UPDATE dbo.SHOPFLOOR_MATERIAL ";
                cmdString += "SET USER_1 = @WIPLocation, ";
                cmdString += "USER_2 = @KittingUserID, ";
                cmdString += "USER_4 = @WipUserID, ";
                cmdString += "USER_5 = @WIPDate ";
                cmdString += "WHERE RECORD_IDENTITY = @RecordID";

                //Properties.Settings.Default.VJSConnectionString
                //Properties.Settings.Default.VJCConnectionString

                using (var sqlCon = new SQLCon(_log))
                {
                    if (sqlCon.Open(Properties.Settings.Default.VJSConnectionString))
                    {
                        sqlCon.TableName = "dbo.SHOPFLOOR_MATERIAL";
                        sqlCon.WhereString = "RECORD_IDENTITY = " + RecordNumber;

                        sqlCon.WriteParameters.Add(new DBParam("USER_1", Locations));
                        sqlCon.WriteParameters.Add(new DBParam("USER_2", KittedBy));
                        sqlCon.WriteParameters.Add(new DBParam("USER_4", WipPullReturnBy));
                        sqlCon.WriteParameters.Add(new DBParam("USER_5", WipPullReturnDate));

                        retVal = sqlCon.Write();
                    }
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
