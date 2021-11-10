using System.Data;

namespace WIPManager.Model
{
    public class DBDecimal : DBItem
    {
        public decimal ValueAsNumber { get; set; } = 0;

        public DBDecimal(string columnName) : base(columnName) { }

        public override void ReadValueFromRow(DataRow row)
        {
            ValueAsNumber = row.Field<decimal>(ColumnName);
            Value = ValueAsNumber.ToString();
        }
    }
}
