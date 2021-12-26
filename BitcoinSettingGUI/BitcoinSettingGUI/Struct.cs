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
        }
    }
}
