using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WIPManager.Utils
{
    public class SQLConnection
    {
        public string TestString;
        public SqlConnection VJSCon = new SqlConnection(Properties.Settings.Default.VJSConnectionString);
        public SqlConnection VJCCon = new SqlConnection(Properties.Settings.Default.VJCConnectionString);

        public bool OpenVJSConnection()
        {
            if (VJSCon.ConnectionString == "")
                VJSCon = new SqlConnection(Properties.Settings.Default.VJSConnectionString);
            if (VJSCon.State != ConnectionState.Open)
                VJSCon.Open();
            return VJSCon.State == ConnectionState.Open;
        }

        public bool OpenVJCConnection()
        {
            if (VJCCon.ConnectionString == "")
                VJCCon = new SqlConnection(Properties.Settings.Default.VJCConnectionString);
            if (VJCCon.State != ConnectionState.Open)
                VJCCon.Open();
            return VJCCon.State == ConnectionState.Open;
        }

    }
}
