using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinSettingGUI
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        public List<object> getSettingData()
        {
            List<object> result = new List<object>();
            try
            {
                string[] file1 = System.IO.File.ReadAllLines("./Setting.txt");
                result.Add(1);
                result.Add(file1);
                return result;
            }
            catch (System.IO.FileNotFoundException e)
            {
                result.Add(0);
                result.Add(e);
                return result;
            }
        }
        private Struct.SettingData GetSettingStruct(List<object> d = null)
        {
            Struct.SettingData data;
            if (d != null)
            {
                var tmp = (String[])d[1];
                data.TelegramToken = tmp[0];
                data.UpbitKey1 = tmp[1];
                data.UpbitKey2 = tmp[2];
                data.BinanceKey1 = tmp[3];
                data.BinanceKey2 = tmp[4];

                String[] three = tmp[5].Split();
                data.UpdateTime = Double.Parse(three[0]);
                data.Log = Boolean.Parse(three[1]);
                data.TestMode = Boolean.Parse(three[2]);

                data.Data = new List<List<object>>();
                for(int i = 6; i < tmp.Length - 6; i++)
                {
                    var sub = tmp[i].Split();
                    List<object> tmp2 = new List<object>();
                    
                    tmp2.Add(sub[0]); // Ticker Name
                    tmp2.Add(Double.Parse(sub[1])); // Low Kimp
                    tmp2.Add(Double.Parse(sub[2])); // High Kimp
                    tmp2.Add(Boolean.Parse(sub[3])); // Alarm OnOff

                    tmp2.Add(Boolean.Parse(sub[4])); // TradeMode

                    tmp2.Add(Int32.Parse(sub[5])); // Sell orderbook Ticks
                    tmp2.Add(Double.Parse(sub[6])); // Sell Binance amounts
                    tmp2.Add(Double.Parse(sub[7])); // Buy Upbit amounts
                    tmp2.Add(Int32.Parse(sub[8])); // Sell orderbook Cancle Ticks

                    tmp2.Add(Int32.Parse(sub[9])); // Buy orderbookc Ticks
                    tmp2.Add(Double.Parse(sub[10])); // Buy Binance amounts
                    tmp2.Add(Double.Parse(sub[11])); // Sell Upbit amounts
                    tmp2.Add(Int32.Parse(sub[12])); // Buy orderbook Cancle Ticks

                    data.Data.Add(tmp2);
                }
            }
            else
            {
                data.TelegramToken = "";
                data.UpbitKey1 = "";
                data.UpbitKey2 = "";
                data.BinanceKey1 = "";
                data.BinanceKey2 = "";
                data.UpdateTime = 1.0F;
                data.Log = true;
                data.TestMode = true;
                data.Data = new List<List<object>>();
            }
            return data;
        }
        private void buttonNewCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1(GetSettingStruct());
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> data = getSettingData();
            if ((int)data[0] == 0)
            {
                buttonNewCreate_Click(sender, e);
                return;
            }
            else
            {
                
            }
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
