using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month;
            string line;

            Console.Write("Write what day is? ");
            line = Console.ReadLine();
            day = int.Parse(line);
            // day
            Console.Write("Write what month is? ");
            line = Console.ReadLine();
            month = int.Parse(line);
            // month

            if (day >= 1 && month == 12)
            {
                Console.Write("This month is December");
            }
            else 
            {
                Console.Write("This month is not December");
            }
            Console.ReadKey();
        }
    }
}
