using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinSettingGUI.Forms
{
    public partial class Home : Form
    {
        protected PerformanceCounter NetCounter;
        public Home()
        {
            InitializeComponent();
        }
        public Home(PerformanceCounter netcounter)
        {
            InitializeComponent();
            this.NetCounter = netcounter;
            this.labelNetworkName.Text = netcounter.InstanceName;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timerNetwork_Tick(object sender, EventArgs e)
        {
            int value = (int)NetCounter.NextValue();
            string unit = " ";
            if (value >= 1e6)
            {
                unit += "M";
                value /= (int)1e6;
            }
            else if(value >= 1e3)
            {
                unit += "K";
                value /= (int)1e3;
            }
            this.labelNetwork.Text = value.ToString() + unit + "bps";
        }
    }
}
