using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            string line;

            Console.Write("Write your number");
            line = Console.ReadLine();
            n1 = int.Parse(line);
            // number
            int x = 1;

            while (x <= n1) 
            {
                Console.WriteLine(x);
                x += 1;
            }
            Console.ReadKey();
        }
    }
}
