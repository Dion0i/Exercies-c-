using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practica32
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int cant1 = 0;
           int cant2 = 0;
           int cant3 = 3;
           int sum;
           float peso;
           string line;


            do
            {
                Console.Write("Write your number");
                line = Console.ReadLine();
                peso = float.Parse(line);
                if (peso >= 10.2)
                {
                    cant1++;
                }
                else
                {
                    if (peso >= 9.2)
                    {
                        cant2++;
                    }
                    else
                    {
                        if (peso > 0)
                        {
                            cant3++;
                        }
                    }
                }
            }
            while (peso != 0);

            sum = cant1 + cant2 + cant3;

            Console.WriteLine("Firts number " + cant1);
            Console.WriteLine("second number " + cant2);
            Console.WriteLine("Third number " + cant3);
            Console.WriteLine("The number of the pluss is: " + sum);

            Console.ReadKey();
        }
    }
}
