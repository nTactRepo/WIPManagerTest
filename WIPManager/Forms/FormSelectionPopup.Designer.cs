namespace WIPManager
{
    partial class FormSelectionPopup
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
            this.buttonXOk = new DevComponents.DotNetBar.ButtonX();
            this.knobControlValue = new DevComponents.Instrumentation.KnobControl();
            this.buttonXCancel = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelXValue = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonXOk
            // 
            this.buttonXOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonXOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXOk.Location = new System.Drawing.Point(172, 26);
            this.buttonXOk.Name = "buttonXOk";
            this.buttonXOk.Size = new System.Drawing.Size(88, 34);
            this.buttonXOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXOk.TabIndex = 0;
            this.buttonXOk.Text = "OK";
            // 
            // knobControlValue
            // 
            this.knobControlValue.AllowDecimalValueSelection = false;
            this.knobControlValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knobControlValue.KnobStyle = DevComponents.Instrumentation.eKnobStyle.Style4;
            this.knobControlValue.Location = new System.Drawing.Point(0, 77);
            this.knobControlValue.MajorTickAmount = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knobControlValue.MaxValue = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.knobControlValue.MinorTickAmount = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knobControlValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knobControlValue.Name = "knobControlValue";
            this.knobControlValue.Size = new System.Drawing.Size(575, 593);
            this.knobControlValue.TabIndex = 1;
            this.knobControlValue.ValueChanged += new System.EventHandler<DevComponents.Instrumentation.ValueChangedEventArgs>(this.knobControlValue_ValueChanged);
            // 
            // buttonXCancel
            // 
            this.buttonXCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonXCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXCancel.Location = new System.Drawing.Point(327, 26);
            this.buttonXCancel.Name = "buttonXCancel";
            this.buttonXCancel.Size = new System.Drawing.Size(88, 34);
            this.buttonXCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXCancel.TabIndex = 0;
            this.buttonXCancel.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXCancel);
            this.panel1.Controls.Add(this.buttonXOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 676);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 72);
            this.panel1.TabIndex = 2;
            // 
            // labelXValue
            // 
            // 
            // 
            // 
            this.labelXValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXValue.Location = new System.Drawing.Point(222, 0);
            this.labelXValue.Name = "labelXValue";
            this.labelXValue.Size = new System.Drawing.Size(127, 69);
            this.labelXValue.TabIndex = 1;
            this.labelXValue.Text = "0";
            this.labelXValue.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelXValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 72);
            this.panel2.TabIndex = 3;
            // 
            // FormSelectionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 748);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.knobControlValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectionPopup";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How many to place here?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectionPopup_FormClosing);
            this.Load += new System.EventHandler(this.FormSelectionPopup_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonXOk;
        private DevComponents.Instrumentation.KnobControl knobControlValue;
        private DevComponents.DotNetBar.ButtonX buttonXCancel;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelXValue;
        private System.Windows.Forms.Panel panel2;
    }
}