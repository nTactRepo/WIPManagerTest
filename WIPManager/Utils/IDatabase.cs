using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPManager.Utils
{
    public class DBParam
    {
        public DBParam(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; } = "";

        public string Value { get; private set; } = "";
    }

    public interface IDatabase
    {
        #region Properties

        /// <summary>
        /// Name of the table to read/write
        /// </summary>
        string TableName { get; set; }
        
        /// <summary>
        /// What type of selection to do on the database
        /// </summary>
        string SelectionString { get; set; }
        
        /// <summary>
        /// Conditions for reading the table
        /// </summary>
        string WhereString { get; set; }

        /// <summary>
        /// List of Parameters to write:  <"Name", value>
        /// </summary>
        List<DBParam> WriteParameters { get; }

        /// <summary>
        /// True if the connection has been successfully opened, false otherwise
        /// </summary>
        bool IsOpen { get; }

        #endregion

        #region Functions

        /// <summary>
        /// Open the connection to the database
        /// </summary>
        /// <param name="connectionString">string to use to ope the connection</param>
        /// <returns>True if open succeeded, false otherwise</returns>
        bool Open(string connectionString);

        /// <summary>
        /// Close the database connection
        /// </summary>
        /// <throws>SQLException</throws>
        void Close();

        /// <summary>
        /// Reads data from the database table into a DataTable
        /// </summary>
        /// <returns>An appropriate DataTable, or null on error</returns>
        DataTable Read();

        /// <summary>
        /// Writes Parameters back out to the table
        /// </summary>
        /// <returns>True if the write succeeded, false otherwise</returns>
        bool Write();

        #endregion
    }
}
