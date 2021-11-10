using System.Data;

namespace WIPManager.Model
{
    public abstract class DBItem
    {
        #region Properties

        public string ColumnName { get; set; }
        public string Value { get; set; }

        #endregion

        #region Functions

        public DBItem(string columnName)
        {
            ColumnName = columnName;
        }

        public abstract void ReadValueFromRow(DataRow row);

        public virtual void Clear()
        {
            Value = "";
        }

        public override string ToString()
        {
            return Value;
        }

        #endregion
    }
}
