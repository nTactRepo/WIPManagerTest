using System.Data;

namespace WIPManager.Model
{
    public class DBString : DBItem
    {
        public DBString(string columnName) : base(columnName) { }

        public override void ReadValueFromRow(DataRow row)
        {
            Value = row.Field<string>(ColumnName);
            Value = Value is null ? "" : Value;
        }
    }
}
