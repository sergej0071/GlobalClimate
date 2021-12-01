using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WeatherTools
{
    public class WeatherTools
    {
        public static int GetTemperature_ZP()
        {
            string info = new WebClient().DownloadString("http://api.weatherstack.com/current?access_key=1e93a9632d8f45265a3cd3949733a911&query=Zaporizhzhya");

            string temperature_info_spoiled = info.Substring(info.IndexOf("\"temperature\":", 0) + "\"temperature\":".Length, 4);

            string temperature_info_only = "";
            for (int i = 0; i < temperature_info_spoiled.Length; i++)
            {
                if (Char.IsDigit(temperature_info_spoiled[i]) || temperature_info_spoiled[i] == '-')
                    temperature_info_only += temperature_info_spoiled[i];
            }

            Int32.TryParse(temperature_info_only, out int temperature_info_digit);
            return temperature_info_digit;
        }
    }
}
