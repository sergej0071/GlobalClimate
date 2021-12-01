using System;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {            

            while (true)
            {
                Console.WriteLine("    Input command");
                var str =  Console.ReadLine();
                switch (str)
                {
                    case "help":
                         Console.WriteLine("   Select command:");
                         Console.WriteLine("   humidity - the command that displays the humidity of Zp City ");
                         Console.WriteLine("   temperature - the command that displays the temperature of Zp City");
                         Console.WriteLine("   end - end of work of program");
                    break;
                    case "temperature":
                        Console.WriteLine("    temperature: " + WeatherTools.WeatherTools.GetTemperature_ZP() + "°C");
                        break;
                    case "humidity":
                        Console.WriteLine("    humidity: " + WeatherTools.WeatherTools.GetHumidity_ZP() + "%");
                        break;                   
                }

                if (str.Equals("end"))
                    break;
            }

            Console.WriteLine("   Thanks!");
        }
    }
}
