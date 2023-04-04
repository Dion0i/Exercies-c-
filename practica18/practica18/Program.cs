using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string line;

            Console.Write("Write to X");
            line = Console.ReadLine();
            x = int.Parse(line);
            // point X
            Console.Write("Write to Y");
            line = Console.ReadLine();
            y = int.Parse(line);
            // point Y

            if (x == 0 && y <= 90)
            {
                Console.Write("This is the firts cuadrant");
            }
            else 
            {
                if (x >= 90 && y <= 180) 
                {
                    Console.Write("This is the second cuadrant");
                }
                else
                {
                    if (x >= 180 && y <= 270)
                    {
                        Console.Write("This the third cuadrant");
                    }
                    else 
                    {
                        if (x >= 270 && y <= 360) 
                        {
                            Console.Write("This the fourth cuadrant");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
