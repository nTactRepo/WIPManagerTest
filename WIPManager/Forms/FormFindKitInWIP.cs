using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WIPManager
{
    public partial class FormFindKitInWIP : Form
    {
        #region Data Members

        private readonly object _lock = new object();
        private Logger _log;

        Timer timerDataEntry = new Timer();
        Timer timerBadWO = new Timer();

        WorkOrder _workOrder;

        #endregion

        #region Constants

        private static readonly string TAG = "FindKitInWIP";

        #endregion

        #region Public Functions

        public FormFindKitInWIP(Logger log)
        {
            InitializeComponent();

            _log = log;
            _workOrder = new WorkOrder(_log);
        }

        #endregion

        #region Private Functions

        private void ClearWOInfo()
        {
            labelXPartID.ResetText();
            labelXDesc.ResetText();
            labelXOrderStatus.ResetText();
            labelXReleaseDate.ResetText();
            labelXCloseDate.ResetText();
            labelXDesiredQty.ResetText();
            labelXRcvdQty.ResetText();
            labelIncomplete.Visible = false;

            _log.log(LogLevel.INFO, TAG, "WO Information cleared");
        }

        private void HandleWOChanged()
        {
            // Update WO parameters
            labelXPartID.Text = _workOrder.PartId;
            labelXDesc.Text = _workOrder.OrderStatus;
            labelXOrderStatus.Text = _workOrder.OrderStatus;
            labelXReleaseDate.Text = _workOrder.ReleaseDate;
            labelXCloseDate.Text = _workOrder.CloseDate;
            labelXDesiredQty.Text = _workOrder.DesiredQty;
            labelXRcvdQty.Text = _workOrder.ReceivedQty;
            labelXWIPLocation.Text = _workOrder.WipLocation;

            // Update Completion Status
            _workOrder.UpdateKittingStatus();

            if (_workOrder.KittingStatus == "COMPLETE")
            {
                labelIncomplete.BackColor = Color.LimeGreen;
                labelIncomplete.Text = "COMPLETE";
            }
            else
            {
                labelIncomplete.BackColor = Color.DarkOrange;
                labelIncomplete.Text = _workOrder.KittingStatus;
            }

            labelIncomplete.Visible = true;
            _log.log(LogLevel.INFO, TAG, "New WO Displayed");
        }

        private string FixInput(string strToFix, bool fullString = false)
        {
            if (string.IsNullOrEmpty(strToFix))
            {
                return string.Empty;
            }

            string newStr = strToFix.Trim('"');

            if (fullString)
            {
                return new string(newStr.Where(c => char.IsLetterOrDigit(c)).ToArray());
            }
            else
            {
                return newStr;
            }
        }

        #endregion

        #region Event Handlers

        private void textBoxXInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            lock (_lock)
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    e.Handled = true;
                    string fixInput = FixInput(textBoxXInput.Text);

                    if (!_workOrder.ReadFromWorkOrderId(fixInput))
                    {
                        _log.log(LogLevel.WARN, "FindKit", "User typed in unknown WO#: " + fixInput);
                        labelXInvalidWO.Visible = true;
                        timerBadWO.Start();
                    }
                    else
                    {
                        _log.log(LogLevel.INFO, TAG, "Used asked to display WO: " + fixInput);
                    }

                    textBoxXInput.Focus();
                }
            }
        }

        private void FormFindKitInWIP_Load(object sender, EventArgs e)
        {
            timerBadWO.Interval = 2500;
            timerBadWO.Tick += TimerBadWO_Tick;

            _workOrder.Changed += HandleWOChanged;
            _workOrder.Cleared += ClearWOInfo;

            _log.log(LogLevel.INFO, TAG, "FindKitInWIP is starting.");
        }

        private void TimerBadWO_Tick(object sender, EventArgs e)
        {
            lock (_lock)
            {
                labelXInvalidWO.Visible = false;
                textBoxXInput.Text = "";
                timerBadWO.Stop();
            }
        }

        #endregion

    }
}
