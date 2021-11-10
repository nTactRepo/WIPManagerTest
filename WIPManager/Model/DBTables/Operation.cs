using System.Data;
using WIPManager.Utils;

namespace WIPManager.Model
{
    public class Operation
    {
        #region Constants

        private const string WorkIDCol = "WORK_ID";
        private const string LotIDCol = "LOT_ID";
        private const string SplitIDCol = "SPLIT_ID";
        private const string SubIDCol = "SUB_ID";
        private const string SeqNumCol = "SEQ_NO";

        #endregion

        #region Properties

        public DBString WorkID { get; private set; } = new DBString(WorkIDCol);
        public DBString LotID { get; private set; } = new DBString(LotIDCol);
        public DBString SplitID { get; private set; } = new DBString(SplitIDCol);
        public DBString SubID { get; private set; } = new DBString(SubIDCol);
        public DBInt SequenceNumber { get; private set; } = new DBInt(SeqNumCol);

        #endregion

        #region Data Members

        private Logger _log = null;

        #endregion

        #region Functions

        #region Constructors

        public Operation(Logger logger, DataRow row)
        {
            _log = logger;

            WorkID.ReadValueFromRow(row);
            LotID.ReadValueFromRow(row);
            SplitID.ReadValueFromRow(row);
            SubID.ReadValueFromRow(row);
            SequenceNumber.ReadValueFromRow(row);
        }

        #endregion

        #region Public Functions
        #endregion

        #region Private Functions
        #endregion

        #endregion
    }
}

