using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinSettingGUI
{
    public static class Struct
    {
        public struct SettingData
        {
            public String TelegramToken;
            public String UpbitKey1;
            public String UpbitKey2;
            public String BinanceKey1;
            public String BinanceKey2;
            public double UpdateTime;
            public bool Log;
            public bool TestMode;
            public List<List<object>> Data;
            public override string ToString()
            {
                String result = "";
                result += TelegramToken + "\n";
                result += UpbitKey1 + "\n";
                result += UpbitKey2 + "\n";
                result += BinanceKey1 + "\n";
                result += BinanceKey2 + "\n";
                result += UpdateTime.ToString() + "\n";
                result += Log.ToString() + "\n";
                result += TestMode.ToString() + "\n";
                foreach(List<object> list1 in Data)
                {
                    foreach(object obj in list1)
                    {
                        result += obj.ToString() + " ";
                    }
                    result += "\n";
                }
                return result;
            }
        }
    }
}
