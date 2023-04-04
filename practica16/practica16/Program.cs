using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practica16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            string line;

            Console.Write("Write the day");
            line = Console.ReadLine();
            day = int.Parse(line);
            // day
            Console.Write("Write the day");
            line = Console.ReadLine();
            month = int.Parse(line);
            // month
            Console.Write("Write the day");
            line = Console.ReadLine();
            year = int.Parse(line);
            //year

            if (month == 1 || month == 2 || month == 3) 
            {
                Console.Write("Corresponde al primer trimestre");
            }
            Console.ReadKey();

        }
    }
}
