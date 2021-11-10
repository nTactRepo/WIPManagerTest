using System;
using System.Data;

namespace WIPManager.Model
{
    public class DBDate : DBItem
    {
        private DateTime? _date = null;

        public DateTime? ValueAsDate
        {
            get { return _date; }

            set
            {
                _date = value;
                Value = _date is null ? "" : _date?.ToShortDateString();
            }
        }

        public DBDate(string columnName) : base(columnName) { }

        public override void ReadValueFromRow(DataRow row)
        {
            ValueAsDate = row.Field<DateTime?>(ColumnName);
            Value = ValueAsDate is null ? "" : string.Format("{0:MM/dd/yyyy}", ValueAsDate);
        }
    }
}
