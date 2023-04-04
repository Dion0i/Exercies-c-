using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            string line;
            //7int x = 0;

            do
            {
                Console.Write("Write your number");
                line = Console.ReadLine();
                value = int.Parse(line);

                if (value >= 100)
                {
                    Console.Write("Has three numbers");
                }
                else
                {
                    if (value >= 10)
                    {
                        Console.Write("Has two numbers");
                    }
                    else
                    {
                        Console.Write("Has one digit");
                    }
                }
            }
            while (value != 0);

            Console.ReadKey();
        }
    }
}
