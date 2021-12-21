using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BitcoinSettingGUI
{
    public partial class ProgressSpinnerDynamic : UserControl
    {
        public ProgressSpinnerDynamic()
        {
            InitializeComponent();
        }
        const int INTERVAL = 2;
        int dir = INTERVAL;
        private void stretch_Tick(object sender, EventArgs e)
        {
            if (this.metroProgressSpinner1.Value == 100)
            {
                dir = -INTERVAL;

            }
            else if(this.metroProgressSpinner1.Value == 0)
            {
                dir = INTERVAL;
            }

            this.metroProgressSpinner1.Value += dir;
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }
    }
}
