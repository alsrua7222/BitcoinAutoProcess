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
            try
            {
                this.NetCounter = netcounter;
                this.labelNetworkName.Text = netcounter.InstanceName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                this.labelNetworkName.Text = "Not Found the LAN Cards.";
            }
        }
        
        private void setSuccessFont(Label label)
        {
            label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = System.Drawing.Color.Lime;
            label.Text = "O";
            return;
        }

        private void setFailFont(Label label)
        {
            label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = System.Drawing.Color.Red;
            label.Text = "X";
            return;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timerNetwork_Tick(object sender, EventArgs e)
        {
            try
            {
                int value = (int)NetCounter.NextValue();
                string unit = " ";
                if (value >= 1e6)
                {
                    unit += "M";
                    value /= (int)1e6;
                }
                else if (value >= 1e3)
                {
                    unit += "K";
                    value /= (int)1e3;
                }
                this.labelNetwork.Text = value.ToString() + unit + "bps";
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }
    }
}
