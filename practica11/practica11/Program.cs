using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string line;

            Console.Write("Write your value: ");
            line = Console.ReadLine();
            num = int.Parse(line);

            if (num <= 9)
            {
                Console.Write("The number has one digit");
            }
            else
            {
                Console.Write("The number has two digit");
            }
            Console.ReadKey();
        }
    }
}
