using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantAll, cantR, porc;
            string line;

            Console.Write("Write right amount");
            line = Console.ReadLine();
            cantAll = int.Parse(line);
            // cant all
            Console.Write("Write right answers");
            line = Console.ReadLine();
            cantR = int.Parse(line);
            // right anwers

            porc = cantR * 100 / cantAll;

            if (porc >= 90) 
            {
                Console.Write("Level up");
            }
            else 
            {
                if (porc >= 75 && porc < 90)
                {
                    Console.Write("Level medium");
                }
                else
                {
                    if (porc >= 50 && porc < 75)
                    {
                        Console.Write("Level down");
                    }
                    else 
                    {
                        Console.Write("outside the level");
                    }
                }
                
            }
            Console.ReadKey();

        }
    }
}
