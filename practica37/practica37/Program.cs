using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica37
{
    class point 
    {
        private int x, y;

        //Firts method
        public void inicializar() 
        {
            string line;
            Console.Write("Write your coordenate x :");
            line = Console.ReadLine();
            x = int.Parse(line);
            Console.Write("Write your coordenate y :");
            line = Console.ReadLine();
            y = int.Parse(line);
        }
        //Second method
        void printCuadrant() 
        {
            if (x > 0 && y > 0) // Body of bucle if...
            {
                Console.Write("it's in a firts cuadrant");
            }
            else 
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("it's in a second cuadrant");
                }
                else 
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("it's in a third cuadrant");
                    }
                    else 
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.Write("it's in a fourth cuadrant");
                        }
                        else 
                        {
                            Console.Write("No have a cuadrant");
                        }
                    }
                }
            } // end The bucle
            Console.ReadKey();
        } // end method

        static void Main(string[] args) // main of the methods 
        {
            point point1 = new point(); // Call of the objects
            point1.inicializar(); // call of the functions
            point1.printCuadrant();
        }
    }
}
