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

    }
}
