namespace WIPManager
{
    partial class FormPlaceInWIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelXInputMessage = new DevComponents.DotNetBar.LabelX();
            this.textBoxXInput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonXClose = new DevComponents.DotNetBar.ButtonX();
            this.labelXWorkOrder = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelXPlaceBy = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.groupPanelInformation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.stepIndicatorWIPIntake = new DevComponents.DotNetBar.Controls.StepIndicator();
            this.labelXSelected = new DevComponents.DotNetBar.LabelX();
            this.labelXNewLocation = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonXAccept = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelWOInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelIncomplete = new DevComponents.DotNetBar.LabelX();
            this.labelXCloseDate = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelXReleaseDate = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelXPartID = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelXOrderStatus = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelXRcvdQty = new DevComponents.DotNetBar.LabelX();
            this.labelXWIPLocations = new DevComponents.DotNetBar.LabelX();
            this.labelXDesc = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelXDesiredQty = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelXInfoMsg = new DevComponents.DotNetBar.LabelX();
            this.checkBoxComplete = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dataGridViewMaterials = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colNoSelected = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colNoUnplaced = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colPieceNo = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colPartNo = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colDescription = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colLocation = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colCalcQty = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colIssuedQty = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colQtyPer = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.panelMaterials = new System.Windows.Forms.Panel();
            this.vScrollBarAdv1Materials = new DevComponents.DotNetBar.VScrollBarAdv();
            this.buttonXClrAll = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxXSelectAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanelInformation.SuspendLayout();
            this.groupPanelWOInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            this.panelMaterials.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelXInputMessage
            // 
            // 
            // 
            // 
            this.labelXInputMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXInputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXInputMessage.Location = new System.Drawing.Point(12, 12);
            this.labelXInputMessage.Name = "labelXInputMessage";
            this.labelXInputMessage.Size = new System.Drawing.Size(957, 46);
            this.labelXInputMessage.TabIndex = 0;
            this.labelXInputMessage.Text = "Scan WorkOrder Barcode";
            this.labelXInputMessage.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBoxXInput
            // 
            // 
            // 
            // 
            this.textBoxXInput.Border.Class = "TextBoxBorder";
            this.textBoxXInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXInput.Location = new System.Drawing.Point(229, 64);
            this.textBoxXInput.Name = "textBoxXInput";
            this.textBoxXInput.PreventEnterBeep = true;
            this.textBoxXInput.Size = new System.Drawing.Size(515, 49);
            this.textBoxXInput.TabIndex = 1;
            this.textBoxXInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXInput_KeyPress);
            // 
            // buttonXClose
            // 
            this.buttonXClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonXClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXClose.Location = new System.Drawing.Point(1002, 393);
            this.buttonXClose.Name = "buttonXClose";
            this.buttonXClose.Size = new System.Drawing.Size(148, 43);
            this.buttonXClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXClose.TabIndex = 2;
            this.buttonXClose.Text = "Close";
            this.buttonXClose.Click += new System.EventHandler(this.buttonXClose_Click);
            // 
            // labelXWorkOrder
            // 
            this.labelXWorkOrder.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXWorkOrder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXWorkOrder.Location = new System.Drawing.Point(149, 22);
            this.labelXWorkOrder.Name = "labelXWorkOrder";
            this.labelXWorkOrder.Size = new System.Drawing.Size(374, 35);
            this.labelXWorkOrder.TabIndex = 3;
            this.labelXWorkOrder.Click += new System.EventHandler(this.labelXWorkOrder_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 22);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(140, 35);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "WO#/Lot:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX3.Click += new System.EventHandler(this.labelXWorkOrder_Click);
            // 
            // labelXPlaceBy
            // 
            this.labelXPlaceBy.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXPlaceBy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXPlaceBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXPlaceBy.Location = new System.Drawing.Point(149, 63);
            this.labelXPlaceBy.Name = "labelXPlaceBy";
            this.labelXPlaceBy.Size = new System.Drawing.Size(374, 35);
            this.labelXPlaceBy.TabIndex = 8;
            this.labelXPlaceBy.Click += new System.EventHandler(this.labelXPlaceBy_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(140, 35);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Picked By:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX4.Click += new System.EventHandler(this.labelXPlaceBy_Click);
            // 
            // groupPanelInformation
            // 
            this.groupPanelInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelInformation.Controls.Add(this.stepIndicatorWIPIntake);
            this.groupPanelInformation.Controls.Add(this.labelXSelected);
            this.groupPanelInformation.Controls.Add(this.labelXNewLocation);
            this.groupPanelInformation.Controls.Add(this.labelXPlaceBy);
            this.groupPanelInformation.Controls.Add(this.labelXWorkOrder);
            this.groupPanelInformation.Controls.Add(this.labelX5);
            this.groupPanelInformation.Controls.Add(this.labelX4);
            this.groupPanelInformation.Controls.Add(this.labelX1);
            this.groupPanelInformation.Controls.Add(this.labelX3);
            this.groupPanelInformation.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelInformation.Location = new System.Drawing.Point(12, 119);
            this.groupPanelInformation.Name = "groupPanelInformation";
            this.groupPanelInformation.Size = new System.Drawing.Size(957, 113);
            // 
            // 
            // 
            this.groupPanelInformation.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelInformation.Style.BackColorGradientAngle = 90;
            this.groupPanelInformation.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelInformation.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderBottomWidth = 1;
            this.groupPanelInformation.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelInformation.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderLeftWidth = 1;
            this.groupPanelInformation.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderRightWidth = 1;
            this.groupPanelInformation.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderTopWidth = 1;
            this.groupPanelInformation.Style.CornerDiameter = 4;
            this.groupPanelInformation.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInformation.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInformation.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInformation.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInformation.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelInformation.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelInformation.TabIndex = 9;
            // 
            // stepIndicatorWIPIntake
            // 
            this.stepIndicatorWIPIntake.CurrentStep = 0;
            this.stepIndicatorWIPIntake.Location = new System.Drawing.Point(3, 0);
            this.stepIndicatorWIPIntake.Name = "stepIndicatorWIPIntake";
            this.stepIndicatorWIPIntake.Size = new System.Drawing.Size(945, 16);
            this.stepIndicatorWIPIntake.StepCount = 3;
            this.stepIndicatorWIPIntake.TabIndex = 10;
            this.stepIndicatorWIPIntake.Text = "stepIndicator1";
            // 
            // labelXSelected
            // 
            this.labelXSelected.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXSelected.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXSelected.Location = new System.Drawing.Point(676, 22);
            this.labelXSelected.Name = "labelXSelected";
            this.labelXSelected.Size = new System.Drawing.Size(254, 35);
            this.labelXSelected.TabIndex = 8;
            this.labelXSelected.Click += new System.EventHandler(this.labelXNewLocation_Click);
            // 
            // labelXNewLocation
            // 
            this.labelXNewLocation.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXNewLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXNewLocation.Location = new System.Drawing.Point(676, 63);
            this.labelXNewLocation.Name = "labelXNewLocation";
            this.labelXNewLocation.Size = new System.Drawing.Size(254, 35);
            this.labelXNewLocation.TabIndex = 8;
            this.labelXNewLocation.Click += new System.EventHandler(this.labelXNewLocation_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(546, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(124, 35);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "New Loc:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX5.Click += new System.EventHandler(this.labelXNewLocation_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(530, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(140, 35);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Selected:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX1.Click += new System.EventHandler(this.labelXWorkOrder_Click);
            // 
            // buttonXAccept
            // 
            this.buttonXAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXAccept.Location = new System.Drawing.Point(1002, 333);
            this.buttonXAccept.Name = "buttonXAccept";
            this.buttonXAccept.Size = new System.Drawing.Size(148, 43);
            this.buttonXAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXAccept.TabIndex = 10;
            this.buttonXAccept.Text = "Accept";
            this.buttonXAccept.Visible = false;
            this.buttonXAccept.Click += new System.EventHandler(this.buttonXAccept_Click);
            // 
            // groupPanelWOInfo
            // 
            this.groupPanelWOInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelWOInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelWOInfo.Controls.Add(this.labelIncomplete);
            this.groupPanelWOInfo.Controls.Add(this.labelXCloseDate);
            this.groupPanelWOInfo.Controls.Add(this.labelX11);
            this.groupPanelWOInfo.Controls.Add(this.labelXReleaseDate);
            this.groupPanelWOInfo.Controls.Add(this.labelX8);
            this.groupPanelWOInfo.Controls.Add(this.labelXPartID);
            this.groupPanelWOInfo.Controls.Add(this.labelX6);
            this.groupPanelWOInfo.Controls.Add(this.labelXOrderStatus);
            this.groupPanelWOInfo.Controls.Add(this.labelX10);
            this.groupPanelWOInfo.Controls.Add(this.labelX2);
            this.groupPanelWOInfo.Controls.Add(this.labelXRcvdQty);
            this.groupPanelWOInfo.Controls.Add(this.labelXWIPLocations);
            this.groupPanelWOInfo.Controls.Add(this.labelXDesc);
            this.groupPanelWOInfo.Controls.Add(this.labelX7);
            this.groupPanelWOInfo.Controls.Add(this.labelXDesiredQty);
            this.groupPanelWOInfo.Controls.Add(this.labelX12);
            this.groupPanelWOInfo.Controls.Add(this.labelX9);
            this.groupPanelWOInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelWOInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanelWOInfo.Location = new System.Drawing.Point(12, 238);
            this.groupPanelWOInfo.Name = "groupPanelWOInfo";
            this.groupPanelWOInfo.Size = new System.Drawing.Size(957, 198);
            // 
            // 
            // 
            this.groupPanelWOInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelWOInfo.Style.BackColorGradientAngle = 90;
            this.groupPanelWOInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelWOInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelWOInfo.Style.BorderBottomWidth = 1;
            this.groupPanelWOInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelWOInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelWOInfo.Style.BorderLeftWidth = 1;
            this.groupPanelWOInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelWOInfo.Style.BorderRightWidth = 1;
            this.groupPanelWOInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelWOInfo.Style.BorderTopWidth = 1;
            this.groupPanelWOInfo.Style.CornerDiameter = 4;
            this.groupPanelWOInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelWOInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.groupPanelWOInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelWOInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelWOInfo.TabIndex = 11;
            this.groupPanelWOInfo.Text = "WorkOrder Information";
            // 
            // labelIncomplete
            // 
            this.labelIncomplete.BackColor = System.Drawing.Color.DarkOrange;
            // 
            // 
            // 
            this.labelIncomplete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomplete.Location = new System.Drawing.Point(757, 6);
            this.labelIncomplete.Name = "labelIncomplete";
            this.labelIncomplete.Size = new System.Drawing.Size(173, 30);
            this.labelIncomplete.TabIndex = 14;
            this.labelIncomplete.Text = "INCOMPLETE";
            this.labelIncomplete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelIncomplete.Visible = false;
            // 
            // labelXCloseDate
            // 
            this.labelXCloseDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXCloseDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXCloseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXCloseDate.Location = new System.Drawing.Point(488, 138);
            this.labelXCloseDate.Name = "labelXCloseDate";
            this.labelXCloseDate.Size = new System.Drawing.Size(241, 28);
            this.labelXCloseDate.TabIndex = 16;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(369, 138);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(113, 28);
            this.labelX11.TabIndex = 15;
            this.labelX11.Text = "CLS Date:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXReleaseDate
            // 
            this.labelXReleaseDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXReleaseDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXReleaseDate.Location = new System.Drawing.Point(124, 139);
            this.labelXReleaseDate.Name = "labelXReleaseDate";
            this.labelXReleaseDate.Size = new System.Drawing.Size(221, 28);
            this.labelXReleaseDate.TabIndex = 14;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(3, 139);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(115, 28);
            this.labelX8.TabIndex = 13;
            this.labelX8.Text = "RLS Date:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXPartID
            // 
            this.labelXPartID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXPartID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXPartID.Location = new System.Drawing.Point(124, 7);
            this.labelXPartID.Name = "labelXPartID";
            this.labelXPartID.Size = new System.Drawing.Size(221, 28);
            this.labelXPartID.TabIndex = 12;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(3, 7);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(115, 28);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "Part ID:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXOrderStatus
            // 
            this.labelXOrderStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXOrderStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXOrderStatus.Location = new System.Drawing.Point(461, 6);
            this.labelXOrderStatus.Name = "labelXOrderStatus";
            this.labelXOrderStatus.Size = new System.Drawing.Size(204, 28);
            this.labelXOrderStatus.TabIndex = 10;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(381, 6);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(74, 28);
            this.labelX10.TabIndex = 9;
            this.labelX10.Text = "Status:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(-3, 105);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 28);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Desired Qty:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXRcvdQty
            // 
            this.labelXRcvdQty.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXRcvdQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXRcvdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXRcvdQty.Location = new System.Drawing.Point(488, 104);
            this.labelXRcvdQty.Name = "labelXRcvdQty";
            this.labelXRcvdQty.Size = new System.Drawing.Size(241, 28);
            this.labelXRcvdQty.TabIndex = 8;
            // 
            // labelXWIPLocations
            // 
            this.labelXWIPLocations.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXWIPLocations.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXWIPLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXWIPLocations.Location = new System.Drawing.Point(124, 71);
            this.labelXWIPLocations.Name = "labelXWIPLocations";
            this.labelXWIPLocations.Size = new System.Drawing.Size(622, 28);
            this.labelXWIPLocations.TabIndex = 3;
            // 
            // labelXDesc
            // 
            this.labelXDesc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXDesc.Location = new System.Drawing.Point(124, 37);
            this.labelXDesc.Name = "labelXDesc";
            this.labelXDesc.Size = new System.Drawing.Size(622, 28);
            this.labelXDesc.TabIndex = 3;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(369, 104);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(113, 28);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "Rcv\'d Qty:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXDesiredQty
            // 
            this.labelXDesiredQty.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXDesiredQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXDesiredQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXDesiredQty.Location = new System.Drawing.Point(124, 105);
            this.labelXDesiredQty.Name = "labelXDesiredQty";
            this.labelXDesiredQty.Size = new System.Drawing.Size(221, 28);
            this.labelXDesiredQty.TabIndex = 5;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(3, 71);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(115, 28);
            this.labelX12.TabIndex = 6;
            this.labelX12.Text = "WIP Locs:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(3, 37);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(115, 28);
            this.labelX9.TabIndex = 6;
            this.labelX9.Text = "Description:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXInfoMsg
            // 
            this.labelXInfoMsg.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.labelXInfoMsg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXInfoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXInfoMsg.Location = new System.Drawing.Point(12, 60);
            this.labelXInfoMsg.Name = "labelXInfoMsg";
            this.labelXInfoMsg.Size = new System.Drawing.Size(957, 56);
            this.labelXInfoMsg.TabIndex = 12;
            this.labelXInfoMsg.Text = "WorkOrder Doesn\'t Exist!";
            this.labelXInfoMsg.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelXInfoMsg.Visible = false;
            // 
            // checkBoxComplete
            // 
            this.checkBoxComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxComplete.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxComplete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxComplete.CheckSignSize = new System.Drawing.Size(30, 30);
            this.checkBoxComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComplete.Location = new System.Drawing.Point(1002, 119);
            this.checkBoxComplete.Name = "checkBoxComplete";
            this.checkBoxComplete.Size = new System.Drawing.Size(170, 60);
            this.checkBoxComplete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxComplete.TabIndex = 13;
            this.checkBoxComplete.Text = "Mark Kit As Complete";
            this.checkBoxComplete.Visible = false;
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.AllowUserToAddRows = false;
            this.dataGridViewMaterials.AllowUserToDeleteRows = false;
            this.dataGridViewMaterials.AllowUserToResizeColumns = false;
            this.dataGridViewMaterials.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoSelected,
            this.colNoUnplaced,
            this.colPieceNo,
            this.colPartNo,
            this.colDescription,
            this.colLocation,
            this.colCalcQty,
            this.colIssuedQty,
            this.colQtyPer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMaterials.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMaterials.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewMaterials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewMaterials.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterials.MultiSelect = false;
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.ReadOnly = true;
            this.dataGridViewMaterials.RowHeadersVisible = false;
            this.dataGridViewMaterials.RowTemplate.Height = 40;
            this.dataGridViewMaterials.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.dataGridViewMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewMaterials.SelectAllSignVisible = false;
            this.dataGridViewMaterials.ShowCellErrors = false;
            this.dataGridViewMaterials.ShowRowErrors = false;
            this.dataGridViewMaterials.Size = new System.Drawing.Size(1134, 319);
            this.dataGridViewMaterials.TabIndex = 14;
            this.dataGridViewMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterials_CellContentClick);
            this.dataGridViewMaterials.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewMaterials_Scroll);
            this.dataGridViewMaterials.SelectionChanged += new System.EventHandler(this.dataGridViewMaterials_SelectionChanged);
            // 
            // colNoSelected
            // 
            this.colNoSelected.HeaderText = "No Selected";
            this.colNoSelected.Name = "colNoSelected";
            this.colNoSelected.ReadOnly = true;
            this.colNoSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNoSelected.Text = "0";
            // 
            // colNoUnplaced
            // 
            this.colNoUnplaced.HeaderText = "No Unplaced";
            this.colNoUnplaced.Name = "colNoUnplaced";
            this.colNoUnplaced.ReadOnly = true;
            this.colNoUnplaced.Width = 80;
            // 
            // colPieceNo
            // 
            this.colPieceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPieceNo.HeaderText = "Piece No";
            this.colPieceNo.Name = "colPieceNo";
            this.colPieceNo.ReadOnly = true;
            this.colPieceNo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colPieceNo.Width = 78;
            // 
            // colPartNo
            // 
            this.colPartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPartNo.HeaderText = "Part No";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.ReadOnly = true;
            this.colPartNo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colPartNo.Width = 68;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 95;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location(s)";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colLocation.Width = 150;
            // 
            // colCalcQty
            // 
            this.colCalcQty.HeaderText = "Calc Qty";
            this.colCalcQty.Name = "colCalcQty";
            this.colCalcQty.ReadOnly = true;
            this.colCalcQty.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // colIssuedQty
            // 
            this.colIssuedQty.HeaderText = "Issued Qty";
            this.colIssuedQty.Name = "colIssuedQty";
            this.colIssuedQty.ReadOnly = true;
            this.colIssuedQty.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // colQtyPer
            // 
            this.colQtyPer.HeaderText = "Qty Per";
            this.colQtyPer.Name = "colQtyPer";
            this.colQtyPer.ReadOnly = true;
            this.colQtyPer.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelMaterials
            // 
            this.panelMaterials.Controls.Add(this.vScrollBarAdv1Materials);
            this.panelMaterials.Controls.Add(this.dataGridViewMaterials);
            this.panelMaterials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMaterials.Location = new System.Drawing.Point(0, 442);
            this.panelMaterials.Name = "panelMaterials";
            this.panelMaterials.Size = new System.Drawing.Size(1184, 319);
            this.panelMaterials.TabIndex = 16;
            // 
            // vScrollBarAdv1Materials
            // 
            this.vScrollBarAdv1Materials.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBarAdv1Materials.LargeChange = 7;
            this.vScrollBarAdv1Materials.Location = new System.Drawing.Point(1134, 0);
            this.vScrollBarAdv1Materials.Name = "vScrollBarAdv1Materials";
            this.vScrollBarAdv1Materials.Size = new System.Drawing.Size(50, 319);
            this.vScrollBarAdv1Materials.TabIndex = 15;
            this.vScrollBarAdv1Materials.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarAdv1Materials_Scroll);
            // 
            // buttonXClrAll
            // 
            this.buttonXClrAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXClrAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXClrAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXClrAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXClrAll.Location = new System.Drawing.Point(1002, 60);
            this.buttonXClrAll.Name = "buttonXClrAll";
            this.buttonXClrAll.Size = new System.Drawing.Size(148, 43);
            this.buttonXClrAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXClrAll.TabIndex = 10;
            this.buttonXClrAll.Text = "Clr. All";
            this.buttonXClrAll.Visible = false;
            this.buttonXClrAll.Click += new System.EventHandler(this.buttonXClrAll_Click);
            // 
            // checkBoxXSelectAll
            // 
            this.checkBoxXSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxXSelectAll.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxXSelectAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXSelectAll.CheckSignSize = new System.Drawing.Size(30, 30);
            this.checkBoxXSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXSelectAll.Location = new System.Drawing.Point(1002, 185);
            this.checkBoxXSelectAll.Name = "checkBoxXSelectAll";
            this.checkBoxXSelectAll.Size = new System.Drawing.Size(170, 35);
            this.checkBoxXSelectAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXSelectAll.TabIndex = 13;
            this.checkBoxXSelectAll.Text = "Select All";
            this.checkBoxXSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxXSelectAll_CheckedChanged);
            // 
            // FormPlaceInWIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.ControlBox = false;
            this.Controls.Add(this.panelMaterials);
            this.Controls.Add(this.checkBoxXSelectAll);
            this.Controls.Add(this.checkBoxComplete);
            this.Controls.Add(this.buttonXClrAll);
            this.Controls.Add(this.buttonXAccept);
            this.Controls.Add(this.groupPanelInformation);
            this.Controls.Add(this.buttonXClose);
            this.Controls.Add(this.labelXInputMessage);
            this.Controls.Add(this.labelXInfoMsg);
            this.Controls.Add(this.textBoxXInput);
            this.Controls.Add(this.groupPanelWOInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPlaceInWIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Kit/Assembly In WIP";
            this.Load += new System.EventHandler(this.FormPlaceInWIP_Load);
            this.groupPanelInformation.ResumeLayout(false);
            this.groupPanelWOInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            this.panelMaterials.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelXInputMessage;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxXInput;
        private DevComponents.DotNetBar.ButtonX buttonXClose;
        private DevComponents.DotNetBar.LabelX labelXWorkOrder;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelXPlaceBy;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInformation;
        private DevComponents.DotNetBar.Controls.StepIndicator stepIndicatorWIPIntake;
        private DevComponents.DotNetBar.ButtonX buttonXAccept;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelWOInfo;
        private DevComponents.DotNetBar.LabelX labelXOrderStatus;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelXRcvdQty;
        private DevComponents.DotNetBar.LabelX labelXDesc;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelXDesiredQty;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelXCloseDate;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelXReleaseDate;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelXPartID;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelXInfoMsg;
        private DevComponents.DotNetBar.LabelX labelIncomplete;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxComplete;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewMaterials;
        private System.Windows.Forms.Panel panelMaterials;
        private DevComponents.DotNetBar.ButtonX buttonXClrAll;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXSelectAll;
        private DevComponents.DotNetBar.LabelX labelXNewLocation;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelXWIPLocations;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelXSelected;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewButtonColumn colNoSelected;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colNoUnplaced;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colPieceNo;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colPartNo;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colLocation;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colCalcQty;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colIssuedQty;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colQtyPer;
        private DevComponents.DotNetBar.VScrollBarAdv vScrollBarAdv1Materials;
    }
}