using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            for (f = 5; f <= 50; f += 5) 
            {
                Console.Write(f);
                Console.Write("_");
            }
            Console.ReadKey();
        }
    }
}
