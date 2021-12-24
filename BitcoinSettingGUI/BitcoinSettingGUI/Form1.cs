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
using MetroFramework.Controls;
using System.Diagnostics;
/*
* https://www.youtube.com/watch?v=BtOEztT1Qzk
* 따라하기 중.
*/
namespace BitcoinSettingGUI
{
    public partial class Form1 : Form
    {
        private List<object> settingDatas;
        private Button currentButton;
        private Form activateForm;
        private Random random;
        private int tempIndex;

        protected PerformanceCounter NetCounter;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            foreach(string s in Network.GetUseAbleLANCards())
            {
                Console.WriteLine(s);
            }
            NetCounter = Network.ShowTheNetworkSpeed();
            //Form2 form2 = new Form2();
            //form2.Show();
            //this.settingDatas = form2.getSettingData();
            //Delay(5000);
            //form2.Close();
            //Console.WriteLine(this.settingDatas);
            //this.metroTextBox1.AppendText(this.settingDatas[0].ToString() + "\n");
            //foreach (string str in this.settingDatas[1] as string[])
            //{
            //    this.metroTextBox1.AppendText(str + "\n");
            //}
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    Color color = SelectThemeColor();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    this.panelTitle.BackColor = color;
                    this.panelMenuTop.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    this.panelTitleName.Text = currentButton.Text;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control obj in this.panelMenu.Controls)
            {
                if (obj.GetType() == typeof(Button))
                {
                    obj.BackColor = Color.FromArgb(51, 51, 76);
                    obj.ForeColor = Color.White;
                    obj.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
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
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.Home(this.NetCounter), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.API(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
