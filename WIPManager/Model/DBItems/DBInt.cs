using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPManager.Model
{
    public class DBInt : DBItem
    {

        public int ValueAsNumber { get; set; } = 0;

        public DBInt(string columnName) : base(columnName) { }

        public override void ReadValueFromRow(DataRow row)
        {
            ValueAsNumber = row.Field<int>(ColumnName);
            Value = ValueAsNumber.ToString();
        }
    }
}
