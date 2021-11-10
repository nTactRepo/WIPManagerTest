using System;
using System.Windows.Forms;

namespace WIPManager
{
    public partial class FormSelectionPopup : Form
    {
        public int MaxValue = 10;
        public int Selection;

        public FormSelectionPopup()
        {
            InitializeComponent();
        }

        private void FormSelectionPopup_Load(object sender, EventArgs e)
        {
            knobControlValue.MaxValue = MaxValue;
            knobControlValue.Value = Selection;

            if (MaxValue > 500)
            {
                knobControlValue.MajorTickAmount = 100;
                knobControlValue.MinorTickAmount = 1;
            }
            else if (MaxValue > 50)
            {
                knobControlValue.MajorTickAmount = 10;
                knobControlValue.MinorTickAmount = 1;
            }
            else
            {
                knobControlValue.MajorTickAmount = 1;
                knobControlValue.MinorTickAmount = 1;
            }

            labelXValue.Text = Selection.ToString();
        }

        private void FormSelectionPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Selection = (int)knobControlValue.Value;
        }

        private void knobControlValue_ValueChanged(object sender, DevComponents.Instrumentation.ValueChangedEventArgs e)
        {
            labelXValue.Text = knobControlValue.Value.ToString();
        }
    }
}
