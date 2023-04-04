using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            string line;
            do // Body of the bucle
            {
                Console.Write("Write your number");
                line = Console.ReadLine();
                num = int.Parse(line);

                if (num != 999) // This conditional not calculate the number 999.
                {
                    sum += num;
                }
            }
            while (num != 999); // if the instruction is 999 the conditional end the cicle.

            if (sum == 0)
            {
                Console.Write("The value is zero" + sum);
            }
            else 
            {
                if (sum > 0)
                {
                    Console.Write("The value is than zero" + sum);
                }
                else 
                {
                    Console.Write("The value is less zero" + sum);
                }
            }
            Console.ReadKey();
        }
    }
}
