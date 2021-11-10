using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WIPManager
{
    public partial class FormGetFromWIP : Form
    {
        #region Data Members

        private State _state = State.Invalid;
        private Operation _operation = Operation.Pull;
        private readonly object _lock = new object();
        private Logger _log;

        private int _numSelected = 0;

        private Timer _timerDataEntry = new Timer();
        private Timer _timerBadWO = new Timer();

        private WorkOrder _workOrder;

        #endregion

        #region Constants and Enums

        private static readonly string TAG = "GetFromWIP";
        private static readonly string FORM_TITLE = "{0} Kit/Assembly {1} WIP";

        private enum State
        {
            GetName = 0,
            GetWO,
            NeedAccept,
            Invalid
        }

        private enum Operation
        {
            Pull,
            Return
        }

        #endregion

        #region Public Functions

        public FormGetFromWIP(Logger log)
        {
            InitializeComponent();

            _log = log;
            _workOrder = new WorkOrder(log);
        }

        #endregion

        #region Private Functions

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

        private void AdjustState()
        {
            State next = GetNextState();
            SetState(next);
        }

        private void ChangeOperation(Operation operation)
        {
            if (_operation == operation)
            {
                return;
            }

            _operation = operation;
            _log.log(LogLevel.INFO, TAG, "Changed to Operation mode: " + operation.ToString());

            radioButtonPullMode.Checked = _operation == Operation.Pull;
            radioButtonReturnMode.Checked = _operation == Operation.Return;

            SetState(_state, force: true);
            HandleWOChanged();
        }

        private State GetNextState()
        {
            State nextState = State.Invalid;

            if (string.IsNullOrEmpty(labelXPlaceBy.Text))
            {
                nextState = State.GetName;
            }
            else if (string.IsNullOrEmpty(labelXWorkOrder.Text))
            {
                nextState = State.GetWO;
            }
            else // We have all we need -- must just need accept
            {
                nextState = State.NeedAccept;
            }

            return nextState;
        }

        private void SetState(State next, bool force = false)
        {
            if (!force && next == _state)
            {
                return;
            }

            _state = next;
            _log.log(LogLevel.INFO, TAG, "New state: " + _state.ToString());

            bool isPull = _operation == Operation.Pull;
            string op = isPull ? "Pull" : "Return";
            string direction = isPull ? "From" : "To";

            switch (_state)
            {
                case State.GetName:
                    labelXInputMessage.Text = "Scan Your ID Barcode";
                    break;

                case State.GetWO:
                    labelXInputMessage.Text = "Scan WorkOrder Barcode";
                    break;

                case State.NeedAccept:
                    labelXInputMessage.Text = "Select Material To " + op + " And Press Accept If Correct";
                    break;

                case State.Invalid:
                    labelXInputMessage.Text = "This program broke!!";
                    break;

                default:
                    System.Diagnostics.Debug.Assert(false, "Unknown state set!  Please fix state transitions!");
                    break;
            }

            // Common to all state transitions
            stepIndicatorWIPIntake.CurrentStep = (int)_state;

            this.Text = string.Format(FORM_TITLE, op, direction);

            textBoxXInput.Text = "";
            textBoxXInput.Focus();
        }

        private clsSelectionData GetSelectionDataInRow(DataGridViewRow row)
        {
            return ((Tuple<Material, clsSelectionData>)row.Tag).Item2;
        }

        private Material GetMaterialInRow(DataGridViewRow row)
        {
            return ((Tuple<Material, clsSelectionData>)row.Tag).Item1;
        }

        private void ClearWOInfo()
        {
            labelXPartID.ResetText();
            labelXOrderStatus.ResetText();
            labelXDesc.ResetText();
            labelXWIPLocations.ResetText();
            labelXReleaseDate.ResetText();
            labelXCloseDate.ResetText();
            labelXDesiredQty.ResetText();
            labelXRcvdQty.ResetText();
            labelXNumSelected.ResetText();

            dataGridViewMaterials.Rows.Clear();
            _log.log(LogLevel.INFO, TAG, "Work Order Information was cleared");
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
            labelXWIPLocations.Text = _workOrder.WipLocation;
            labelXWorkOrder.Text = _workOrder.WorkID + "/" + _workOrder.LotID;

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

            // Now, update the materials
            dataGridViewMaterials.Rows.Clear();
            dataGridViewMaterials.Rows.Add();

            foreach (var material in _workOrder.Materials)
            {
                DataGridViewRow viewRow = (DataGridViewRow)dataGridViewMaterials.Rows[0].Clone();
                var sd = new clsSelectionData(material.Locations, (int)material.IssuedQty, material.RecordNumber);
                viewRow.Tag = new Tuple<Material, clsSelectionData>(material, sd);

                var cell = viewRow.Cells[colSelected.Index];
                cell.Value = false;
                cell.ReadOnly = sd.Locations.TotalCount == 0;

                viewRow.Cells[colPieceNo.Index].Value = material.PieceNO;
                viewRow.Cells[colPartNo.Index].Value = material.PartNO;
                viewRow.Cells[colDescription.Index].Value = material.Description;
                viewRow.Cells[colLocation.Index].Value = material.Locations.ToString();
                viewRow.Cells[colCalcQty.Index].Value = material.CalqQty.ToString();
                viewRow.Cells[colIssuedQty.Index].Value = material.IssuedQty;
                viewRow.Cells[colQtyPer.Index].Value = material.QtyPer;

                if ((_operation == Operation.Pull && (sd.Locations.TotalCount == 0 || sd.Locations.OnMfgFloor)) ||
                    (_operation == Operation.Return && !sd.Locations.OnMfgFloor))
                {
                    viewRow.DefaultCellStyle.BackColor = Color.Red;
                    viewRow.ReadOnly = true;
                }

                dataGridViewMaterials.Rows.Add(viewRow);
            }

            dataGridViewMaterials.Rows.Remove(dataGridViewMaterials.Rows[0]);
            vScrollBarAdvMaterials.Maximum = dataGridViewMaterials.Rows.Count;

            _log.log(LogLevel.INFO, TAG, "New WO " + _workOrder.WorkID + " information with " + dataGridViewMaterials.Rows.Count + " material rows");
        }

        private void AdjustRows()
        {
            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                if (IsSelected(row))
                {
                    var sd = GetSelectionDataInRow(row);
                    sd.Locations.OnMfgFloor = _operation == Operation.Pull;

                    var material = GetMaterialInRow(row);
                    material.RecordNumber = sd.RecordId;
                    material.Locations = sd.Locations.ToString();
                    material.WipPullReturnBy = labelXPlaceBy.Text;
                    material.WipPullReturnDate = DateTime.Now.ToShortDateString();
                }
            }
        }

        private void SetAllSelections(bool selected)
        {
            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                row.Cells[colSelected.Index].Value = selected ? "true" : "false";               
            }
        }

        private bool IsSelected(DataGridViewRow row)
        {
            bool selected = false;
            var cell = row.Cells[colSelected.Index];

            if (Convert.ToBoolean(cell.Value))
            {
                selected = true;
            }

            return selected;
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

                    switch (_state)
                    {
                        case State.GetName:
                            labelXPlaceBy.Text = FixInput(textBoxXInput.Text);
                            break;

                        case State.GetWO:
                            string fixedString = FixInput(textBoxXInput.Text, fullString: true);
                            _log.log(LogLevel.INFO, TAG, "Used asked for WO, record ID: " + fixedString);

                            if (!_workOrder.ReadFromRecordId(fixedString))
                            {
                                _log.log(LogLevel.WARN, TAG, "Could not find WO");
                                textBoxXInput.Text = "";
                                textBoxXInput.Focus();
                                labelXInvalidWO.Visible = true;
                                _timerBadWO.Start();
                                return;
                            }

                            break;
                    }

                    AdjustState();
                }
            }
        }

        private void FormGetFromWIP_Load(object sender, EventArgs e)
        {
            SetState(State.GetName);
            _timerDataEntry.Interval = 100;
            _timerDataEntry.Tick += TimerDataEntry_Tick;
            _timerDataEntry.Start();
            _timerBadWO.Interval = 2500;
            _timerBadWO.Tick += TimerBadWO_Tick;

            _workOrder.Changed += HandleWOChanged;
            _workOrder.Cleared += ClearWOInfo;
            _log.log(LogLevel.INFO, TAG, "WO Info cleared.");
        }

        private void TimerDataEntry_Tick(object sender, EventArgs e)
        {
            lock (_lock)
            {
                _timerDataEntry.Stop();

                AdjustState();

                _numSelected = 0;

                foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
                {
                    var cell = row.Cells[colSelected.Index];

                    if (Convert.ToBoolean(cell.Value))
                    {
                        ++_numSelected;
                    }
                }

                labelXNumSelected.Text = _numSelected.ToString();
                labelXNumSelected.BackColor = _state == State.NeedAccept && _numSelected == 0 ? Color.Red : Color.Transparent;

                buttonXAccept.Visible = _state == State.NeedAccept && _numSelected > 0;
                textBoxXInput.Visible = _state != State.NeedAccept;
                checkBoxXSelectAll.Visible = _state == State.NeedAccept;

                textBoxXInput.Focus();

                _timerDataEntry.Start();
            }
        }

        private void TimerBadWO_Tick(object sender, EventArgs e)
        {
            labelXInvalidWO.Visible = false;
            labelXWorkOrder.Text = "";
            _timerBadWO.Stop();
        }
        private void labelXWorkOrder_Click(object sender, EventArgs e)
        {
            labelXWorkOrder.Text = "";
            _workOrder.Clear();
        }

        private void labelXPlaceBy_Click(object sender, EventArgs e)
        {
            labelXPlaceBy.Text = "";
        }

        private void buttonXAccept_Click(object sender, EventArgs e)
        {
            AdjustRows();

            _workOrder.UpdateWipLocationFromMaterials();
            _workOrder.WipDate = DateTime.Now.ToShortDateString();
            _workOrder.WipUserID = labelXPlaceBy.Text;
            _workOrder.Write();
            _log.log(LogLevel.INFO, TAG, "");

            labelXWorkOrder.Text = "";
            _workOrder.Clear();
        }

        private void checkBoxXSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            SetAllSelections(checkBoxXSelectAll.Checked);
        }

        private void radioButtonPullMode_Click(object sender, EventArgs e)
        {
            ChangeOperation(Operation.Pull);
        }

        private void labelXPullMode_Click(object sender, EventArgs e)
        {
            ChangeOperation(Operation.Pull);
        }

        private void radioButtonReturnMode_Click(object sender, EventArgs e)
        {
            ChangeOperation(Operation.Return);
        }

        private void labelXReturnMode_Click(object sender, EventArgs e)
        {
            ChangeOperation(Operation.Return);
        }

        private void dataGridViewMaterials_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                vScrollBarAdvMaterials.Value = e.NewValue;
            }
        }

        private void vScrollBarAdvMaterials_Scroll(object sender, ScrollEventArgs e)
        {
            if (dataGridViewMaterials.Rows.Count > 0)
            {
                dataGridViewMaterials.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }

        #endregion

    }
}
