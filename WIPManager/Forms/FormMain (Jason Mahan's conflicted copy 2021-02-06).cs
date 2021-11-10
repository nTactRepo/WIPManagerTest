using System;
using System.Windows.Forms;
using WIPManager.Utils;

namespace WIPManager
{
    public partial class FormMain : Form
    {
        public Logger guiLog;

        public FormMain()
        {
            InitializeComponent();

            guiLog = new Logger(6, "Logs", "Activity", "WIPMgr Gui Logger");
        }

        private void metroTileItemPlaceInWIP_Click(object sender, EventArgs e)
        {
            FormPlaceInWIP placeInWIP = new FormPlaceInWIP(guiLog);
            placeInWIP.ShowDialog(this);
        }

        private void metroTileItemRemoveFromWIP_Click(object sender, EventArgs e)
        {
            FormGetFromWIP getFromWIP = new FormGetFromWIP(guiLog);
            getFromWIP.ShowDialog(this);
        }

        private void metroTileItemFindKit_Click(object sender, EventArgs e)
        {
            FormFindKitInWIP findKitInWIP = new FormFindKitInWIP(guiLog);
            findKitInWIP.ShowDialog(this);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            guiLog.shutdown();
        }
    }
}
