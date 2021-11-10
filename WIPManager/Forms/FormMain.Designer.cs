namespace WIPManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItemPlaceInWIP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItemRemoveFromWIP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItemFindKit = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroTilePanel1.Location = new System.Drawing.Point(32, 273);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ReserveLeftSpace = false;
            this.metroTilePanel1.Size = new System.Drawing.Size(1120, 214);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItemPlaceInWIP,
            this.metroTileItemRemoveFromWIP,
            this.metroTileItemFindKit});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleText = "First";
            this.itemContainer1.TitleVisible = false;
            // 
            // metroTileItemPlaceInWIP
            // 
            this.metroTileItemPlaceInWIP.Name = "metroTileItemPlaceInWIP";
            this.metroTileItemPlaceInWIP.Stretch = true;
            this.metroTileItemPlaceInWIP.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItemPlaceInWIP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItemPlaceInWIP.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItemPlaceInWIP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItemPlaceInWIP.TitleText = "Put In WIP";
            this.metroTileItemPlaceInWIP.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItemPlaceInWIP.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItemPlaceInWIP.Click += new System.EventHandler(this.metroTileItemPlaceInWIP_Click);
            // 
            // metroTileItemRemoveFromWIP
            // 
            this.metroTileItemRemoveFromWIP.Name = "metroTileItemRemoveFromWIP";
            this.metroTileItemRemoveFromWIP.Stretch = true;
            this.metroTileItemRemoveFromWIP.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItemRemoveFromWIP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItemRemoveFromWIP.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItemRemoveFromWIP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItemRemoveFromWIP.TitleText = "Get From WIP";
            this.metroTileItemRemoveFromWIP.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItemRemoveFromWIP.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItemRemoveFromWIP.Click += new System.EventHandler(this.metroTileItemRemoveFromWIP_Click);
            // 
            // metroTileItemFindKit
            // 
            this.metroTileItemFindKit.Name = "metroTileItemFindKit";
            this.metroTileItemFindKit.Stretch = true;
            this.metroTileItemFindKit.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItemFindKit.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItemFindKit.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItemFindKit.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItemFindKit.TitleText = "Find Kit or Assembly";
            this.metroTileItemFindKit.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItemFindKit.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItemFindKit.Click += new System.EventHandler(this.metroTileItemFindKit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.metroTilePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "nTact WIP Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItemPlaceInWIP;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItemRemoveFromWIP;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItemFindKit;
    }
}

