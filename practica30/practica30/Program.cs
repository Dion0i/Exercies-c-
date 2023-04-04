using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumV1 = 0;
            int sumV2 = 0;
            int sumV3 = 0;
            int promDay, promAfternoon, promNigth;     
            int x, f, y,tdDay, tdAfternoon, tdNigth;
            string line;

            for (x = 1; x <= 6; x++) 
            {
                Console.Write("Write your age1");
                line = Console.ReadLine();
                tdDay = int.Parse(line);

                sumV1 += tdDay;
            }

            for (f = 1; f <= 6; f++)
            {
                Console.Write("Write your age2");
                line = Console.ReadLine();
                tdAfternoon = int.Parse(line);

                sumV2 += tdAfternoon;
            }

            for (y = 1; y <= 6; y++)
            {
                Console.Write("Write your age3");
                line = Console.ReadLine();
                tdNigth = int.Parse(line);

                sumV3 += tdNigth;
            }

            promDay = sumV1 / 6;
            promAfternoon = sumV2 / 6;
            promNigth = sumV3 / 6;

            Console.WriteLine(promDay);
            Console.WriteLine(promAfternoon);
            Console.WriteLine(promNigth);

            if (promDay < promAfternoon && promDay < promNigth)
            {
                Console.WriteLine("Promedio menor Day");
            }
            else 
            {
                if (promAfternoon < promDay && promAfternoon < promNigth)
                {
                    Console.WriteLine("Promedio menor Afternoon");
                }
                else 
                {
                    Console.WriteLine("Promedio menor Nigth");
                }
            }
            Console.ReadKey();
        }
    }
}
