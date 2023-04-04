using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practica25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int list1, list2;
            string line; 
            int acm1 = 0;
            int acm2 = 0;
            int x = 1;
            int y = 1;
            
            // 1ra
            while (x <= 5) 
            {
                Console.Write("Write your firts list");
                line = Console.ReadLine();
                list1 = int.Parse(line);

                acm1 += list1;

                x += 1;
            }
            // 2do
            while (y <= 5)
            {
                Console.Write("Write your second list");
                line = Console.ReadLine();
                list2 = int.Parse(line);

                acm2 += list2;

                y += 1;
            }

            if (acm1 > acm2)
            {
                Console.WriteLine("List 1");
            }
            else 
            {
                if (acm2 > acm1)
                {
                    Console.WriteLine("List 2");
                }
                else 
                {
                    Console.Write("List equal");
                }
            }

            Console.ReadKey();
        }
    }
}
