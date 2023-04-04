using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            string line;

            Console.Write("Firts number");
            line = Console.ReadLine();
            n1 = int.Parse(line);
            //Firts
            Console.Write("Second number");
            line = Console.ReadLine();
            n2 = int.Parse(line);
            //Second
            Console.Write("Third number");
            line = Console.ReadLine();
            n3 = int.Parse(line);
            //Third

            if (n1 > n2 && n1 > n3)
            {
                Console.Write("I am biggest n1");
            }
            else 
            {
                if (n2 > n1 && n2 > n3)
                {
                    Console.Write("I am biggest n2");
                }
                else 
                {
                    Console.Write("I am biggest n3");
                }
            }
            Console.ReadKey();
        }
    }
}
