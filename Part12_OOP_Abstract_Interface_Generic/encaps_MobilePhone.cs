using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part12_OOP_Abstract_Interface_Generic
{
        public abstract class MobilePhone // ABSTRACT CLASS 
        {
            private string _microChip; // private members accessible only within the class 

            public string Shape { get; set; } //public members means can be use by other class 
            public string Color { get; set; }

            public void PowerOn() // yung ibang class na gumagamit ng PowerOn na method di na nila need malaman kung ano yung ginagawa nito internally basta ang alam lang nila is to power on parang capsule lang sya sa gamot naka encapsulate sa loob mismo yung gamot di na natin need malaman kung ano ano yng mga nakalagay na poweder dun sa loob basta alam natin gamot to for specific na sakin  
            {
                ConnectMainboardToPowerSupply(); // inside ni power on method is tinawag natin yung dalawang nakaprivate na method dun sa baba , kaya sya naka private para maprotectahan natin yung process and yung data na di kaylangan makita sa labas 
                OpenWifiChip();
            }

            private void ConnectMainboardToPowerSupply()
            {
                // Implementation for connecting the mainboard to the power supply
            }

            private void OpenWifiChip()
            {
                // Implementation for opening the WiFi chip
            }

            // Example abstract method (optional, based on your requirements)
            public abstract void MakeCall(string phoneNumber);
        }

}