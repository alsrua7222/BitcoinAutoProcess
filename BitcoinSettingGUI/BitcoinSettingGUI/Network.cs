using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace BitcoinSettingGUI
{
    public static class Network
    {
        public static String[] GetUseAbleLANCards()
        {
            List<string> list = new List<string>();
            foreach(NetworkInterface network in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (network.OperationalStatus == OperationalStatus.Up)
                {
                    list.Add(network.Description.ToString());
                    Console.WriteLine(network.GetPhysicalAddress().ToString());
                }
            }
            return list.ToArray();
        }
        public static PerformanceCounter ShowTheNetworkSpeed()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            String NetworkCard = adapters[0].Description.ToString();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.OperationalStatus == OperationalStatus.Up &&
                    !String.IsNullOrEmpty(adapter.GetPhysicalAddress().ToString()))
                {
                    NetworkCard = adapter.Description.ToString();
                    break;
                }
            }
            

            PerformanceCounter NetCounter;

            NetworkCard = NetworkCard.Replace('(', '[');
            NetworkCard = NetworkCard.Replace(')', ']');
            NetworkCard = NetworkCard.Replace('/', '_');

            NetCounter = new PerformanceCounter();
            NetCounter.CategoryName = "Network Interface";
            NetCounter.CounterName = "Bytes Total/sec";
            NetCounter.InstanceName = NetworkCard;

            return NetCounter;
        }
    }
}
