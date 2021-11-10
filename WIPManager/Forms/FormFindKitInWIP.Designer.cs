namespace WIPManager
{
    partial class FormFindKitInWIP
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
            this.labelXInputMessage = new DevComponents.DotNetBar.LabelX();
            this.textBoxXInput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonXClose = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelWOInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelWIPUserID = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelKitUserID = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelWIPDate = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelXWIPLocation = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
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
            this.labelXDesc = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelXDesiredQty = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelXInvalidWO = new DevComponents.DotNetBar.LabelX();
            this.groupPanelWOInfo.SuspendLayout();
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
            this.labelXInputMessage.Size = new System.Drawing.Size(366, 46);
            this.labelXInputMessage.TabIndex = 0;
            this.labelXInputMessage.Text = "Enter WorkOrder No:";
            this.labelXInputMessage.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // textBoxXInput
            // 
            // 
            // 
            // 
            this.textBoxXInput.Border.Class = "TextBoxBorder";
            this.textBoxXInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXInput.Location = new System.Drawing.Point(384, 9);
            this.textBoxXInput.Name = "textBoxXInput";
            this.textBoxXInput.PreventEnterBeep = true;
            this.textBoxXInput.Size = new System.Drawing.Size(388, 49);
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
            this.buttonXClose.Location = new System.Drawing.Point(624, 355);
            this.buttonXClose.Name = "buttonXClose";
            this.buttonXClose.Size = new System.Drawing.Size(148, 43);
            this.buttonXClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXClose.TabIndex = 2;
            this.buttonXClose.Text = "Close";
            // 
            // groupPanelWOInfo
            // 
            this.groupPanelWOInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelWOInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelWOInfo.Controls.Add(this.labelWIPUserID);
            this.groupPanelWOInfo.Controls.Add(this.labelX12);
            this.groupPanelWOInfo.Controls.Add(this.labelKitUserID);
            this.groupPanelWOInfo.Controls.Add(this.labelX5);
            this.groupPanelWOInfo.Controls.Add(this.labelWIPDate);
            this.groupPanelWOInfo.Controls.Add(this.labelX4);
            this.groupPanelWOInfo.Controls.Add(this.labelXWIPLocation);
            this.groupPanelWOInfo.Controls.Add(this.labelX3);
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
            this.groupPanelWOInfo.Controls.Add(this.labelXDesc);
            this.groupPanelWOInfo.Controls.Add(this.labelX7);
            this.groupPanelWOInfo.Controls.Add(this.labelXDesiredQty);
            this.groupPanelWOInfo.Controls.Add(this.labelX9);
            this.groupPanelWOInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelWOInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanelWOInfo.Location = new System.Drawing.Point(12, 73);
            this.groupPanelWOInfo.Name = "groupPanelWOInfo";
            this.groupPanelWOInfo.Size = new System.Drawing.Size(760, 266);
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
            // labelWIPUserID
            // 
            this.labelWIPUserID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelWIPUserID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelWIPUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWIPUserID.Location = new System.Drawing.Point(477, 162);
            this.labelWIPUserID.Name = "labelWIPUserID";
            this.labelWIPUserID.Size = new System.Drawing.Size(217, 28);
            this.labelWIPUserID.TabIndex = 24;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(275, 162);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(197, 28);
            this.labelX12.TabIndex = 23;
            this.labelX12.Text = "Pulled From WIP By:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelKitUserID
            // 
            this.labelKitUserID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelKitUserID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelKitUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKitUserID.Location = new System.Drawing.Point(477, 131);
            this.labelKitUserID.Name = "labelKitUserID";
            this.labelKitUserID.Size = new System.Drawing.Size(217, 28);
            this.labelKitUserID.TabIndex = 22;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(350, 131);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(122, 28);
            this.labelX5.TabIndex = 21;
            this.labelX5.Text = "Kitted By:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelWIPDate
            // 
            this.labelWIPDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelWIPDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelWIPDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWIPDate.Location = new System.Drawing.Point(130, 131);
            this.labelWIPDate.Name = "labelWIPDate";
            this.labelWIPDate.Size = new System.Drawing.Size(115, 28);
            this.labelWIPDate.TabIndex = 20;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 131);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(122, 28);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "WIP Date:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXWIPLocation
            // 
            this.labelXWIPLocation.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXWIPLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXWIPLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXWIPLocation.Location = new System.Drawing.Point(130, 208);
            this.labelXWIPLocation.Name = "labelXWIPLocation";
            this.labelXWIPLocation.Size = new System.Drawing.Size(342, 28);
            this.labelXWIPLocation.TabIndex = 18;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 208);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(122, 28);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "WIP Loc\'s:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelIncomplete
            // 
            this.labelIncomplete.BackColor = System.Drawing.Color.DarkOrange;
            // 
            // 
            // 
            this.labelIncomplete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomplete.Location = new System.Drawing.Point(578, 6);
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
            this.labelXCloseDate.Location = new System.Drawing.Point(477, 100);
            this.labelXCloseDate.Name = "labelXCloseDate";
            this.labelXCloseDate.Size = new System.Drawing.Size(115, 28);
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
            this.labelX11.Location = new System.Drawing.Point(359, 100);
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
            this.labelXReleaseDate.Location = new System.Drawing.Point(130, 100);
            this.labelXReleaseDate.Name = "labelXReleaseDate";
            this.labelXReleaseDate.Size = new System.Drawing.Size(115, 28);
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
            this.labelX8.Location = new System.Drawing.Point(3, 100);
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
            this.labelXPartID.Location = new System.Drawing.Point(130, 7);
            this.labelXPartID.Name = "labelXPartID";
            this.labelXPartID.Size = new System.Drawing.Size(97, 28);
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
            this.labelXOrderStatus.Location = new System.Drawing.Point(390, 7);
            this.labelXOrderStatus.Name = "labelXOrderStatus";
            this.labelXOrderStatus.Size = new System.Drawing.Size(143, 28);
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
            this.labelX10.Location = new System.Drawing.Point(290, 7);
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
            this.labelX2.Location = new System.Drawing.Point(3, 69);
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
            this.labelXRcvdQty.Location = new System.Drawing.Point(477, 69);
            this.labelXRcvdQty.Name = "labelXRcvdQty";
            this.labelXRcvdQty.Size = new System.Drawing.Size(69, 28);
            this.labelXRcvdQty.TabIndex = 8;
            // 
            // labelXDesc
            // 
            this.labelXDesc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXDesc.Location = new System.Drawing.Point(131, 38);
            this.labelXDesc.Name = "labelXDesc";
            this.labelXDesc.Size = new System.Drawing.Size(620, 28);
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
            this.labelX7.Location = new System.Drawing.Point(329, 69);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(143, 28);
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
            this.labelXDesiredQty.Location = new System.Drawing.Point(131, 69);
            this.labelXDesiredQty.Name = "labelXDesiredQty";
            this.labelXDesiredQty.Size = new System.Drawing.Size(69, 28);
            this.labelXDesiredQty.TabIndex = 5;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(3, 38);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(122, 28);
            this.labelX9.TabIndex = 6;
            this.labelX9.Text = "Description:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelXInvalidWO
            // 
            this.labelXInvalidWO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelXInvalidWO.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.labelXInvalidWO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXInvalidWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXInvalidWO.Location = new System.Drawing.Point(13, 345);
            this.labelXInvalidWO.Name = "labelXInvalidWO";
            this.labelXInvalidWO.Size = new System.Drawing.Size(448, 56);
            this.labelXInvalidWO.TabIndex = 12;
            this.labelXInvalidWO.Text = "WorkOrder Doesn\'t Exist!";
            this.labelXInvalidWO.Visible = false;
            // 
            // FormFindKitInWIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.ControlBox = false;
            this.Controls.Add(this.labelXInvalidWO);
            this.Controls.Add(this.groupPanelWOInfo);
            this.Controls.Add(this.buttonXClose);
            this.Controls.Add(this.textBoxXInput);
            this.Controls.Add(this.labelXInputMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormFindKitInWIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Kit or Assembly";
            this.Load += new System.EventHandler(this.FormFindKitInWIP_Load);
            this.groupPanelWOInfo.ResumeLayout(false);
            this.groupPanelWOInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelXInputMessage;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxXInput;
        private DevComponents.DotNetBar.ButtonX buttonXClose;
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
        private DevComponents.DotNetBar.LabelX labelXWIPLocation;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelWIPUserID;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelKitUserID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelWIPDate;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}