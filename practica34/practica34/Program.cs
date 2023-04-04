using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace practica34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cuenta, saldo;
            int sumSaldo = 0;
            string line;

            do // Body cicle
            {
                Console.Write("Write your number 0f the count (if you write -1 the bucle end)");
                line = Console.ReadLine();
                Cuenta = int.Parse(line);

                if (Cuenta >= 0) 
                {
                    Console.Write("Write your saldo");
                    line = Console.ReadLine();
                    saldo = int.Parse(line);

                    if (saldo > 0)
                    {
                        Console.WriteLine("Acreedor");
                        sumSaldo += saldo;
                    }
                    else 
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Deudor");
                        }
                        else
                        {
                            Console.WriteLine("nulo");
                        }
                    }
                }

            }
            while (Cuenta >= 0); // end 0f the bucle

           

            Console.Write("The value all is: " + sumSaldo);
            

            Console.ReadKey();
        }
    }
}
