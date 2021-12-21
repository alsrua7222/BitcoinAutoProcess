using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
/*
* https://www.youtube.com/watch?v=BtOEztT1Qzk
* 따라하기 중.
*/
namespace BitcoinSettingGUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private List<object> settingDatas;
        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.Show();
            this.settingDatas = form2.getSettingData();
            Delay(5000);
            form2.Close();
            Console.WriteLine(this.settingDatas);
            //this.metroTextBox1.AppendText(this.settingDatas[0].ToString() + "\n");
            //foreach (string str in this.settingDatas[1] as string[])
            //{
            //    this.metroTextBox1.AppendText(str + "\n");
            //}
        }
        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }
    }
}
