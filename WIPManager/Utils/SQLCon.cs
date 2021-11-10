using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WIPManager.Utils
{
    public class SQLCon : IDatabase, IDisposable
    {
        // Add a comment

        private const string TAG = "SQLCon";


        private SqlConnection _sql = null;
        private Logger _log = null;

        public SQLCon(Logger logger)
        {
            _log = logger;
        }

        #region IDatabase

        public string ConnectionString { get; set; } = "";

        public string TableName { get; set; } = "";

        public string SelectionString { get; set; } = "SELECT *";

        public string WhereString { get; set; } = "";

        public List<DBParam> WriteParameters { get; private set; } = new List<DBParam>();

        public bool IsOpen => (_sql != null) ? _sql.State == ConnectionState.Open : false;

        public bool Open(string connectionString)
        {
            try
            {
                if (IsOpen)
                {
                    Close();
                }


                _sql = new SqlConnection(connectionString);
                _sql.Open();
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, TAG, "Error opening SQL Connection: " + ex.Message);
            }

            return IsOpen;
        }

        public void Close()
        {
            if (IsOpen)
            {
                _sql.Close();
            }
        }

        public DataTable Read()
        {
            throw new NotImplementedException();
        }

        public bool Write()
        {
            bool wrote = false;

            try
            {
                if (!IsOpen)
                {
                    _log.log(LogLevel.WARN, TAG, "Tried to write a non-open SQL Connection");
                    return false;
                }

                string cmdString = "UPDATE " + TableName + " SET";
                bool first = true;

                foreach (var param in WriteParameters)
                {
                    if (!first)
                    {
                        cmdString += ",";
                    }

                    cmdString += " " + param.Name + " = '" + param.Value + "'";
                    first = false;
                }

                cmdString += " WHERE " + WhereString;

                SqlCommand newCmd = new SqlCommand(cmdString, _sql);
                int updateCount = newCmd.ExecuteNonQuery();
                wrote = updateCount > 0;
            }
            catch (Exception ex)
            {
                _log.log(LogLevel.ERROR, TAG, "Exception doing SQL write: " + ex.Message);
            }

            return wrote;
        }

        #endregion

        #region IDisposable Support

        private bool _hasDisposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_hasDisposed)
            {
                if (disposing)
                {
                    try
                    {
                        _sql.Close();
                    }
                    catch (SqlException ex)
                    {
                        _log.log(LogLevel.ERROR, TAG, "Error closing SQL Connection: " + ex.Message);
                    }
                }

                _hasDisposed = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }

        #endregion


        //public string TestString;
        //public SqlConnection VJSCon = new SqlConnection(Properties.Settings.Default.VJSConnectionString);
        //public SqlConnection VJCCon = new SqlConnection(Properties.Settings.Default.VJCConnectionString);

        //public bool OpenVJSConnection()
        //{
        //    if (VJSCon.ConnectionString == "")
        //        VJSCon = new SqlConnection(Properties.Settings.Default.VJSConnectionString);
        //    if (VJSCon.State != ConnectionState.Open)
        //        VJSCon.Open();
        //    return VJSCon.State == ConnectionState.Open;
        //}

        //public bool OpenVJCConnection()
        //{
        //    if (VJCCon.ConnectionString == "")
        //        VJCCon = new SqlConnection(Properties.Settings.Default.VJCConnectionString);
        //    if (VJCCon.State != ConnectionState.Open)
        //        VJCCon.Open();
        //    return VJCCon.State == ConnectionState.Open;
        //}

    }
}
