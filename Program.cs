using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang;
            Console.WriteLine("Enter Country code");
            cCode = Console.ReadLine();
            switch (cCode)
            {
                case "uk":
                    {
                        lang = "English";
                        break;
                    }
                case "af":
                    {
                        lang = "Dari,Pashto";
                        break;
                    }
                case "in":
                    {
                        lang = "telugu.hindi,English";
                        break;
                    }
                case "uae":
                    {
                        lang = "Arabic";
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"sorry!! your country{cCode}is not in ourDb");
                        lang = "Not Found!!!";
                            break;
                    }
            }

            Console.WriteLine("Country Code" + cCode + "language(s)" + lang);
            Console.ReadKey();

        }
    }
}
