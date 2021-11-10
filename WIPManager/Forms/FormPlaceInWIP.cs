using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPManager
{
    public partial class FormPlaceInWIP : Form
    {
        #region Data Mambers

        private State _state = State.Invalid;
        private readonly object _lock = new object();
        private Logger _log;
        
        private Timer timerDataEntry = new Timer();
        private Timer timerBadWO = new Timer();

        private WorkOrder _workOrder;

        private int _numSelected = 0;
        private bool _allowDebug = false;

        #endregion

        #region Constants and Enums

        private static readonly string TAG = "PlaceInWIP";

        private enum State
        {
            GetName = 0,
            GetWO,
            GetLocation,
            NeedAccept,
            Invalid
        }

        #endregion

        #region Public Functions

        public FormPlaceInWIP(Logger log)
        {
            InitializeComponent();

            _log = log;
            _workOrder = new WorkOrder(log);
        }

        #endregion

        #region Private Functions

        private void AdjustRows(string location)
        {
            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                var sd = GetSelectionDataInRow(row);

                if (sd.NumSelected > 0)
                {
                    sd.AddLocation(location, sd.NumSelected);

                    var material = GetMaterialInRow(row);
                    material.RecordNumber = sd.RecordId;
                    material.Locations = sd.Locations.ToString();
                    material.KittedBy = labelXPlaceBy.Text;
                    material.WipPullReturnDate = DateTime.Now.ToShortDateString();
                }
            }
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
            labelXDesc.ResetText();
            labelXWIPLocations.ResetText();
            labelXOrderStatus.ResetText();
            labelXReleaseDate.ResetText();
            labelXCloseDate.ResetText();
            labelXDesiredQty.ResetText();
            labelXRcvdQty.ResetText();
            labelXNewLocation.ResetText();
            labelXSelected.ResetText();

            dataGridViewMaterials.Rows.Clear();
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
            labelXWIPLocations.Text = _workOrder.WipLocation;
            labelXWorkOrder.Text = _workOrder.WorkID + "/" + _workOrder.LotID;

            // Update Completion Status
            _workOrder.UpdateKittingStatus();

            if (_workOrder.KittingStatus == "COMPLETE")
            {
                labelIncomplete.BackColor = Color.LimeGreen;
                labelIncomplete.Text = "COMPLETE";
                checkBoxComplete.Visible = false;
            }
            else
            {
                labelIncomplete.BackColor = Color.DarkOrange;
                labelIncomplete.Text = _workOrder.KittingStatus;
                checkBoxComplete.Visible = true;
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

                viewRow.Cells[colNoSelected.Index].Value = sd.NumSelected;
                viewRow.Cells[colNoUnplaced.Index].Value = sd.TotalRemaining.ToString();
                viewRow.Cells[colPieceNo.Index].Value = material.PieceNO;
                viewRow.Cells[colPartNo.Index].Value = material.PartNO;
                viewRow.Cells[colDescription.Index].Value = material.Description;
                viewRow.Cells[colLocation.Index].Value = material.Locations;
                viewRow.Cells[colCalcQty.Index].Value = material.CalqQty.ToString();
                viewRow.Cells[colIssuedQty.Index].Value = material.IssuedQty;
                viewRow.Cells[colQtyPer.Index].Value = material.QtyPer;

                dataGridViewMaterials.Rows.Add(viewRow);
            }

            dataGridViewMaterials.Rows.Remove(dataGridViewMaterials.Rows[0]);
            vScrollBarAdv1Materials.Maximum = dataGridViewMaterials.Rows.Count;

            _log.log(LogLevel.INFO, TAG, "New WO Info, ID: " + _workOrder.WorkID + ", " + dataGridViewMaterials.Rows.Count + " material rows");
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

        private void AdjustState()
        {
            State next = GetNextState();
            SetState(next);
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
            else if (string.IsNullOrEmpty(labelXNewLocation.Text))
            {
                nextState = State.GetLocation;
            }
            else // We have all we need -- must just need accept
            {
                nextState = State.NeedAccept;
            }

            return nextState;
        }

        private void SetState(State next)
        {
            if (next == _state)
            {
                return;
            }

            _state = next;
            _log.log(LogLevel.INFO, TAG, "New state in PlaceInWIP: " + _state.ToString());

            switch (_state)
            {
                case State.GetName:
                    labelXInputMessage.Text = "Scan Your ID Barcode";
                    break;

                case State.GetWO:
                    labelXInputMessage.Text = "Scan WorkOrder Barcode";
                    break;

                case State.GetLocation:
                    labelXInputMessage.Text = "Scan WIP Location Barcode";

                    if (_numSelected == 0)
                    {
                        labelXInfoMsg.Visible = true;
                        labelXInfoMsg.Text = "Select some materials to place";
                        timerBadWO.Start();
                    }
                    break;

                case State.NeedAccept:
                    labelXInputMessage.Text = "Press Accept If Correct";
                    break;

                case State.Invalid:
                    labelXInputMessage.Text = "This program broke!!";
                    break;

                default:
                    System.Diagnostics.Debug.Assert(false, "Unknown state set!  Please fix state transitions!");
                    _log.log(LogLevel.ERROR, TAG, "Unknown state!!!  Coding error!");
                    break;
            }

            stepIndicatorWIPIntake.CurrentStep = (int)_state;
            textBoxXInput.Text = "";
            textBoxXInput.Focus();
        }

        [System.Diagnostics.Conditional("DEBUG")]
        private void SetAllowDebugControls()
        {
            _log.log(LogLevel.INFO, TAG, "Debug controls enabled");
            _allowDebug = true;
        }

        #endregion

        #region Event Handlers

        private void FormPlaceInWIP_Load(object sender, EventArgs e)
        {
            SetAllowDebugControls();

            SetState(State.GetName);

            timerDataEntry.Interval = 100;
            timerDataEntry.Tick += TimerDataEntry_Tick;
            timerDataEntry.Start();
            timerBadWO.Interval = 2500;
            timerBadWO.Tick += TimerBadWO_Tick;

            _workOrder.Changed += HandleWOChanged;
            _workOrder.Cleared += ClearWOInfo;
            _log.log(LogLevel.INFO, TAG, "PlaceInWIP is starting.");
        }

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

                            // If it works, the WO read will fill the WO label, which will advance state
                            if (!_workOrder.ReadFromRecordId(fixedString))
                            {
                                _log.log(LogLevel.WARN, TAG, "Unable to find WO.");

                                textBoxXInput.Text = "";
                                textBoxXInput.Focus();
                                labelXInfoMsg.Visible = true;
                                labelXInfoMsg.Text = "WorkOrder Doesn't Exist!";
                                timerBadWO.Start();
                                return;
                            }

                            break;
                        case State.GetLocation:
                            labelXNewLocation.Text = FixInput(textBoxXInput.Text);
                            break;
                    }

                    AdjustState();
                }
            }
        }

        private void TimerDataEntry_Tick(object sender, EventArgs e)
        {
            lock (_lock)
            {
                timerDataEntry.Stop();
                AdjustState();

                _numSelected = 0;

                foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
                {
                    var sd = GetSelectionDataInRow(row);
                    _numSelected += sd.NumSelected;

                    var material = GetMaterialInRow(row);

                    if (material.IssuedQty < material.CalqQty)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (sd.Locations.TotalCount == material.CalqQty)
                    {
                        row.DefaultCellStyle.BackColor = Color.PaleGreen;
                    }
                }

                labelXSelected.Text = _numSelected.ToString();
                labelXSelected.BackColor = ((_state == State.NeedAccept || _state == State.GetLocation) && _numSelected == 0) ? Color.Red : Color.Transparent;

                buttonXAccept.Visible = _state == State.NeedAccept && _numSelected > 0;
                checkBoxXSelectAll.Visible = _state == State.GetLocation || _state == State.NeedAccept;
                buttonXClrAll.Visible = (_state == State.GetLocation || _state == State.NeedAccept) && _allowDebug;

                textBoxXInput.Visible = !(_state == State.NeedAccept) && !(_state == State.GetLocation && _numSelected == 0);
                textBoxXInput.Focus();

                timerDataEntry.Start();
            }
        }

        private void TimerBadWO_Tick(object sender, EventArgs e)
        {
            timerBadWO.Stop();
            labelXInfoMsg.Visible = false;
        }
        private void labelXWorkOrder_Click(object sender, EventArgs e)
        {
            labelXWorkOrder.Text = "";
            _workOrder.Clear();
        }

        private void labelXNewLocation_Click(object sender, EventArgs e)
        {
            labelXNewLocation.Text = "";
        }

        private void labelXPlaceBy_Click(object sender, EventArgs e)
        {
            labelXPlaceBy.Text = "";
        }

        private void buttonXAccept_Click(object sender, EventArgs e)
        {
            AdjustRows(labelXNewLocation.Text);

            // First, set some of the Work Order data that we want to write
            _workOrder.KittingStatus = checkBoxComplete.Checked ? "COMPLETE" : "INCOMPLETE";
            _workOrder.KittedByUserID = labelXPlaceBy.Text;
            _workOrder.WipDate = DateTime.Now.ToShortDateString();
            _workOrder.UpdateWipLocationFromMaterials();

            // Now write
            _workOrder.Write();
            string msg = string.Format("User {0} placed material from WO {1} into location {2}",
                labelXPlaceBy.Text, _workOrder.WorkID, labelXNewLocation.Text);
            _log.log(LogLevel.INFO, TAG, msg);

            HandleWOChanged();

            labelXNewLocation.Text = "";
        }

        private void buttonXClose_Click(object sender, EventArgs e)
        {
            _log.log(LogLevel.INFO, TAG, "User selected Close Button");
        }


        private void buttonOpenMaterialsView_Click(object sender, EventArgs e)
        {
            panelMaterials.Visible = !panelMaterials.Visible;
        }

        private void buttonXClrAll_Click(object sender, EventArgs e)
        {
            _log.log(LogLevel.INFO, TAG, "User asked for all location data in WO " + _workOrder.WorkID + " to be cleared.");

            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                var sd = GetSelectionDataInRow(row);
                sd.Clear();
                var material = GetMaterialInRow(row);
                material.Locations = "";
            }

            _workOrder.WipLocation = "";
            _workOrder.Write();

            HandleWOChanged();
        }

        private void checkBoxXSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAll = checkBoxXSelectAll.Checked;

            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                var sd = GetSelectionDataInRow(row);
                sd.NumSelected = selectAll ? sd.TotalRemaining : 0;
                row.Cells[colNoSelected.Index].Value = sd.NumSelected.ToString();
            }
        }

        private void dataGridViewMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure a button was pushed
            if (e.ColumnIndex != colNoSelected.Index || e.RowIndex < 0)
            {
                return;
            }

            var row = dataGridViewMaterials.Rows[e.RowIndex];
            var sd = GetSelectionDataInRow(row);
            var material = GetMaterialInRow(row);

            // If there is nothing to select, do not allow editing
            if (sd.TotalRemaining == 0)
            {
                return;
            }

            var popup = new FormSelectionPopup();
            popup.MaxValue = sd.TotalRemaining;
            popup.Selection = sd.NumSelected;

            if (popup.ShowDialog() == DialogResult.OK)
            {
                sd.NumSelected = popup.Selection;
                var cell = row.Cells[e.ColumnIndex];
                cell.Value = sd.NumSelected.ToString();
            }
        }

        private void dataGridViewMaterials_SelectionChanged(object sender, EventArgs e)
        {
            // This is to stop cells from being selected -- really don't want them selected!
            dataGridViewMaterials.ClearSelection();
        }

        private void dataGridViewMaterials_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                vScrollBarAdv1Materials.Value = e.NewValue;
            }
        }

        private void vScrollBarAdv1Materials_Scroll(object sender, ScrollEventArgs e)
        {
            if (dataGridViewMaterials.Rows.Count > 0)
            {
                dataGridViewMaterials.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }

        #endregion

    }
}