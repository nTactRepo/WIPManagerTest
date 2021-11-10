namespace WIPManager
{
    partial class FormGetFromWIP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelXInputMessage = new DevComponents.DotNetBar.LabelX();
            this.textBoxXInput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonXClose = new DevComponents.DotNetBar.ButtonX();
            this.labelXWorkOrder = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelXPlaceBy = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.groupPanelInformation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.stepIndicatorWIPIntake = new DevComponents.DotNetBar.Controls.StepIndicator();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelXLocation = new DevComponents.DotNetBar.LabelX();
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelXInvalidWO = new DevComponents.DotNetBar.LabelX();
            this.panelMaterials = new System.Windows.Forms.Panel();
            this.vScrollBarAdvMaterials = new DevComponents.DotNetBar.VScrollBarAdv();
            this.dataGridViewMaterials = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSelected = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.colPieceNo = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colPartNo = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colDescription = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colLocation = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colCalcQty = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colIssuedQty = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.colQtyPer = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.checkBoxXSelectAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonReturnMode = new System.Windows.Forms.RadioButton();
            this.radioButtonPullMode = new System.Windows.Forms.RadioButton();
            this.labelXReturnMode = new DevComponents.DotNetBar.LabelX();
            this.labelXPullMode = new DevComponents.DotNetBar.LabelX();
            this.labelXNumSelected = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.panelLocation = new System.Windows.Forms.Panel();
            this.groupPanelInformation.SuspendLayout();
            this.groupPanelWOInfo.SuspendLayout();
            this.panelMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelLocation.SuspendLayout();
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
            this.labelXInputMessage.Size = new System.Drawing.Size(972, 46);
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
            this.textBoxXInput.Size = new System.Drawing.Size(529, 49);
            this.textBoxXInput.TabIndex = 1;
            this.textBoxXInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXInput_KeyPress);
            // 
            // buttonXClose
            // 
            this.buttonXClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonXClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXClose.Location = new System.Drawing.Point(1024, 381);
            this.buttonXClose.Name = "buttonXClose";
            this.buttonXClose.Size = new System.Drawing.Size(148, 43);
            this.buttonXClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXClose.TabIndex = 2;
            this.buttonXClose.Text = "Close";
            // 
            // labelXWorkOrder
            // 
            this.labelXWorkOrder.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXWorkOrder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXWorkOrder.Location = new System.Drawing.Point(204, 13);
            this.labelXWorkOrder.Name = "labelXWorkOrder";
            this.labelXWorkOrder.Size = new System.Drawing.Size(442, 35);
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
            this.labelX3.Location = new System.Drawing.Point(3, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(195, 35);
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
            this.labelXPlaceBy.Location = new System.Drawing.Point(204, 54);
            this.labelXPlaceBy.Name = "labelXPlaceBy";
            this.labelXPlaceBy.Size = new System.Drawing.Size(442, 35);
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
            this.labelX4.Location = new System.Drawing.Point(3, 54);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(195, 35);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "User ID:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX4.Click += new System.EventHandler(this.labelXPlaceBy_Click);
            // 
            // groupPanelInformation
            // 
            this.groupPanelInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelInformation.Controls.Add(this.panelLocation);
            this.groupPanelInformation.Controls.Add(this.stepIndicatorWIPIntake);
            this.groupPanelInformation.Controls.Add(this.labelXPlaceBy);
            this.groupPanelInformation.Controls.Add(this.labelXWorkOrder);
            this.groupPanelInformation.Controls.Add(this.labelX4);
            this.groupPanelInformation.Controls.Add(this.labelX13);
            this.groupPanelInformation.Controls.Add(this.labelXNumSelected);
            this.groupPanelInformation.Controls.Add(this.labelX3);
            this.groupPanelInformation.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelInformation.Location = new System.Drawing.Point(12, 119);
            this.groupPanelInformation.Name = "groupPanelInformation";
            this.groupPanelInformation.Size = new System.Drawing.Size(972, 98);
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
            this.stepIndicatorWIPIntake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stepIndicatorWIPIntake.CurrentStep = 0;
            this.stepIndicatorWIPIntake.Location = new System.Drawing.Point(3, 0);
            this.stepIndicatorWIPIntake.Name = "stepIndicatorWIPIntake";
            this.stepIndicatorWIPIntake.Size = new System.Drawing.Size(960, 13);
            this.stepIndicatorWIPIntake.StepCount = 2;
            this.stepIndicatorWIPIntake.TabIndex = 10;
            this.stepIndicatorWIPIntake.Text = "stepIndicator1";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(3, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(146, 35);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "Location:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX5.Click += new System.EventHandler(this.labelXWorkOrder_Click);
            // 
            // labelXLocation
            // 
            this.labelXLocation.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXNumSelected.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXLocation.Location = new System.Drawing.Point(155, 9);
            this.labelXLocation.Name = "labelXLocation";
            this.labelXLocation.Size = new System.Drawing.Size(156, 28);
            this.labelXLocation.TabIndex = 10;
            // 
            // buttonXAccept
            // 
            this.buttonXAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXAccept.Location = new System.Drawing.Point(1024, 322);
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
            this.groupPanelWOInfo.Controls.Add(this.labelX1);
            this.groupPanelWOInfo.Controls.Add(this.labelX9);
            this.groupPanelWOInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelWOInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanelWOInfo.Location = new System.Drawing.Point(12, 223);
            this.groupPanelWOInfo.Name = "groupPanelWOInfo";
            this.groupPanelWOInfo.Size = new System.Drawing.Size(972, 201);
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
            this.labelIncomplete.Location = new System.Drawing.Point(755, 6);
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
            this.labelXCloseDate.Location = new System.Drawing.Point(547, 143);
            this.labelXCloseDate.Name = "labelXCloseDate";
            this.labelXCloseDate.Size = new System.Drawing.Size(177, 28);
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
            this.labelX11.Location = new System.Drawing.Point(436, 143);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(105, 28);
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
            this.labelXReleaseDate.Location = new System.Drawing.Point(131, 139);
            this.labelXReleaseDate.Name = "labelXReleaseDate";
            this.labelXReleaseDate.Size = new System.Drawing.Size(299, 28);
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
            this.labelX8.Location = new System.Drawing.Point(3, 143);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(122, 28);
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
            this.labelXPartID.Location = new System.Drawing.Point(131, 7);
            this.labelXPartID.Name = "labelXPartID";
            this.labelXPartID.Size = new System.Drawing.Size(299, 28);
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
            this.labelX6.Size = new System.Drawing.Size(122, 28);
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
            this.labelXOrderStatus.Location = new System.Drawing.Point(549, 7);
            this.labelXOrderStatus.Name = "labelXOrderStatus";
            this.labelXOrderStatus.Size = new System.Drawing.Size(175, 28);
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
            this.labelX10.Location = new System.Drawing.Point(449, 7);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(94, 28);
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
            this.labelX2.Location = new System.Drawing.Point(3, 109);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(122, 28);
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
            this.labelXRcvdQty.Location = new System.Drawing.Point(547, 109);
            this.labelXRcvdQty.Name = "labelXRcvdQty";
            this.labelXRcvdQty.Size = new System.Drawing.Size(177, 28);
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
            this.labelXWIPLocations.Location = new System.Drawing.Point(131, 75);
            this.labelXWIPLocations.Name = "labelXWIPLocations";
            this.labelXWIPLocations.Size = new System.Drawing.Size(797, 28);
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
            this.labelXDesc.Location = new System.Drawing.Point(131, 41);
            this.labelXDesc.Name = "labelXDesc";
            this.labelXDesc.Size = new System.Drawing.Size(797, 28);
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
            this.labelX7.Location = new System.Drawing.Point(436, 109);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(105, 28);
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
            this.labelXDesiredQty.Location = new System.Drawing.Point(131, 109);
            this.labelXDesiredQty.Name = "labelXDesiredQty";
            this.labelXDesiredQty.Size = new System.Drawing.Size(299, 28);
            this.labelXDesiredQty.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 75);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(122, 28);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "WIP Locs:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(3, 41);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(122, 28);
            this.labelX9.TabIndex = 6;
            this.labelX9.Text = "Description:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXInvalidWO
            // 
            this.labelXInvalidWO.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.labelXInvalidWO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXInvalidWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXInvalidWO.Location = new System.Drawing.Point(12, 60);
            this.labelXInvalidWO.Name = "labelXInvalidWO";
            this.labelXInvalidWO.Size = new System.Drawing.Size(972, 56);
            this.labelXInvalidWO.TabIndex = 12;
            this.labelXInvalidWO.Text = "WorkOrder Doesn\'t Exist!";
            this.labelXInvalidWO.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelXInvalidWO.Visible = false;
            // 
            // panelMaterials
            // 
            this.panelMaterials.Controls.Add(this.vScrollBarAdvMaterials);
            this.panelMaterials.Controls.Add(this.dataGridViewMaterials);
            this.panelMaterials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMaterials.Location = new System.Drawing.Point(0, 442);
            this.panelMaterials.Name = "panelMaterials";
            this.panelMaterials.Size = new System.Drawing.Size(1184, 319);
            this.panelMaterials.TabIndex = 17;
            // 
            // vScrollBarAdvMaterials
            // 
            this.vScrollBarAdvMaterials.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBarAdvMaterials.LargeChange = 7;
            this.vScrollBarAdvMaterials.Location = new System.Drawing.Point(1134, 0);
            this.vScrollBarAdvMaterials.Name = "vScrollBarAdvMaterials";
            this.vScrollBarAdvMaterials.Size = new System.Drawing.Size(50, 319);
            this.vScrollBarAdvMaterials.TabIndex = 15;
            this.vScrollBarAdvMaterials.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarAdvMaterials_Scroll);
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.AllowUserToAddRows = false;
            this.dataGridViewMaterials.AllowUserToDeleteRows = false;
            this.dataGridViewMaterials.AllowUserToResizeColumns = false;
            this.dataGridViewMaterials.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colPieceNo,
            this.colPartNo,
            this.colDescription,
            this.colLocation,
            this.colCalcQty,
            this.colIssuedQty,
            this.colQtyPer});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMaterials.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMaterials.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewMaterials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewMaterials.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterials.MultiSelect = false;
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.RowHeadersVisible = false;
            this.dataGridViewMaterials.RowTemplate.Height = 40;
            this.dataGridViewMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewMaterials.SelectAllSignVisible = false;
            this.dataGridViewMaterials.ShowCellErrors = false;
            this.dataGridViewMaterials.ShowRowErrors = false;
            this.dataGridViewMaterials.Size = new System.Drawing.Size(1134, 319);
            this.dataGridViewMaterials.TabIndex = 14;
            this.dataGridViewMaterials.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewMaterials_Scroll);
            // 
            // colSelected
            // 
            this.colSelected.Checked = true;
            this.colSelected.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.colSelected.CheckValue = "N";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSelected.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSelected.HeaderText = "Selected";
            this.colSelected.Name = "colSelected";
            // 
            // colPieceNo
            // 
            this.colPieceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPieceNo.HeaderText = "Piece No";
            this.colPieceNo.Name = "colPieceNo";
            this.colPieceNo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colPieceNo.Width = 78;
            // 
            // colPartNo
            // 
            this.colPartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPartNo.HeaderText = "Part No";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colPartNo.Width = 68;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDescription.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 95;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location(s)";
            this.colLocation.Name = "colLocation";
            this.colLocation.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colLocation.Width = 150;
            // 
            // colCalcQty
            // 
            this.colCalcQty.HeaderText = "Calc Qty";
            this.colCalcQty.Name = "colCalcQty";
            this.colCalcQty.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // colIssuedQty
            // 
            this.colIssuedQty.HeaderText = "Issued Qty";
            this.colIssuedQty.Name = "colIssuedQty";
            this.colIssuedQty.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // colQtyPer
            // 
            this.colQtyPer.HeaderText = "Qty Per";
            this.colQtyPer.Name = "colQtyPer";
            this.colQtyPer.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.checkBoxXSelectAll.Location = new System.Drawing.Point(1024, 176);
            this.checkBoxXSelectAll.Name = "checkBoxXSelectAll";
            this.checkBoxXSelectAll.Size = new System.Drawing.Size(148, 35);
            this.checkBoxXSelectAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXSelectAll.TabIndex = 18;
            this.checkBoxXSelectAll.Text = "Select All";
            this.checkBoxXSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxXSelectAll_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonReturnMode);
            this.groupBox1.Controls.Add(this.radioButtonPullMode);
            this.groupBox1.Controls.Add(this.labelXReturnMode);
            this.groupBox1.Controls.Add(this.labelXPullMode);
            this.groupBox1.Location = new System.Drawing.Point(1000, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 134);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pull/Return";
            // 
            // radioButtonReturnMode
            // 
            this.radioButtonReturnMode.AutoCheck = false;
            this.radioButtonReturnMode.AutoSize = true;
            this.radioButtonReturnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReturnMode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonReturnMode.Location = new System.Drawing.Point(24, 91);
            this.radioButtonReturnMode.Name = "radioButtonReturnMode";
            this.radioButtonReturnMode.Size = new System.Drawing.Size(14, 13);
            this.radioButtonReturnMode.TabIndex = 0;
            this.radioButtonReturnMode.UseVisualStyleBackColor = true;
            this.radioButtonReturnMode.Click += new System.EventHandler(this.radioButtonReturnMode_Click);
            // 
            // radioButtonPullMode
            // 
            this.radioButtonPullMode.AutoCheck = false;
            this.radioButtonPullMode.AutoSize = true;
            this.radioButtonPullMode.Checked = true;
            this.radioButtonPullMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPullMode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonPullMode.Location = new System.Drawing.Point(24, 33);
            this.radioButtonPullMode.Name = "radioButtonPullMode";
            this.radioButtonPullMode.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPullMode.TabIndex = 0;
            this.radioButtonPullMode.TabStop = true;
            this.radioButtonPullMode.UseVisualStyleBackColor = true;
            this.radioButtonPullMode.Click += new System.EventHandler(this.radioButtonPullMode_Click);
            // 
            // labelXReturnMode
            // 
            this.labelXReturnMode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXReturnMode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXReturnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXReturnMode.Location = new System.Drawing.Point(44, 80);
            this.labelXReturnMode.Name = "labelXReturnMode";
            this.labelXReturnMode.Size = new System.Drawing.Size(128, 35);
            this.labelXReturnMode.TabIndex = 7;
            this.labelXReturnMode.Text = "Return";
            this.labelXReturnMode.Click += new System.EventHandler(this.labelXReturnMode_Click);
            // 
            // labelXPullMode
            // 
            this.labelXPullMode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXPullMode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXPullMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXPullMode.Location = new System.Drawing.Point(44, 22);
            this.labelXPullMode.Name = "labelXPullMode";
            this.labelXPullMode.Size = new System.Drawing.Size(128, 35);
            this.labelXPullMode.TabIndex = 7;
            this.labelXPullMode.Text = "Pull";
            this.labelXPullMode.Click += new System.EventHandler(this.labelXPullMode_Click);
            // 
            // labelXNumSelected
            // 
            this.labelXNumSelected.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXNumSelected.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXNumSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXNumSelected.Location = new System.Drawing.Point(804, 19);
            this.labelXNumSelected.Name = "labelXNumSelected";
            this.labelXNumSelected.Size = new System.Drawing.Size(124, 28);
            this.labelXNumSelected.TabIndex = 10;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(652, 13);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(146, 35);
            this.labelX13.TabIndex = 6;
            this.labelX13.Text = "Selected:";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX13.Click += new System.EventHandler(this.labelXWorkOrder_Click);
            // 
            // panelLocation
            // 
            this.panelLocation.BackColor = System.Drawing.Color.Transparent;
            this.panelLocation.Controls.Add(this.labelX5);
            this.panelLocation.Controls.Add(this.labelXLocation);
            this.panelLocation.Location = new System.Drawing.Point(649, 49);
            this.panelLocation.Name = "panelLocation";
            this.panelLocation.Size = new System.Drawing.Size(314, 42);
            this.panelLocation.TabIndex = 16;
            this.panelLocation.Visible = false;
            // 
            // FormGetFromWIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxXSelectAll);
            this.Controls.Add(this.panelMaterials);
            this.Controls.Add(this.groupPanelWOInfo);
            this.Controls.Add(this.buttonXAccept);
            this.Controls.Add(this.groupPanelInformation);
            this.Controls.Add(this.buttonXClose);
            this.Controls.Add(this.labelXInputMessage);
            this.Controls.Add(this.textBoxXInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelXInvalidWO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGetFromWIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Kit/Assembly From WIP";
            this.Load += new System.EventHandler(this.FormGetFromWIP_Load);
            this.groupPanelInformation.ResumeLayout(false);
            this.groupPanelWOInfo.ResumeLayout(false);
            this.panelMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLocation.ResumeLayout(false);
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
        private DevComponents.DotNetBar.LabelX labelXInvalidWO;
        private DevComponents.DotNetBar.LabelX labelIncomplete;
        private System.Windows.Forms.Panel panelMaterials;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewMaterials;
        private DevComponents.DotNetBar.LabelX labelXWIPLocations;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelXLocation;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXSelectAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonReturnMode;
        private System.Windows.Forms.RadioButton radioButtonPullMode;
        private DevComponents.DotNetBar.LabelX labelXReturnMode;
        private DevComponents.DotNetBar.LabelX labelXPullMode;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colSelected;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colPieceNo;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colPartNo;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colLocation;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colCalcQty;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colIssuedQty;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colQtyPer;
        private DevComponents.DotNetBar.VScrollBarAdv vScrollBarAdvMaterials;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelXNumSelected;
        private System.Windows.Forms.Panel panelLocation;
    }
}