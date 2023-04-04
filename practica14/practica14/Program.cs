using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practica14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            string line;

            Console.Write("Write the number");
            line = Console.ReadLine();
            n1 = int.Parse(line);

            if (n1 >= 100 && n1 <= 999)
            {
                Console.Write("He has three numbers");
            }
            else 
            {
                if (n1 >= 10 && n1 <= 99)
                {
                    Console.Write("He has two numbers");
                }
                else 
                {
                    if (n1 >= 1 && n1 <= 9)
                    {
                        Console.Write("He has one numbers");
                    }
                    else 
                    {
                        Console.Write("error");
                    }
                }
            }
         
            Console.ReadKey();
        }
    }
}
