using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica36
{
    class Triangle 
    {
        private int side1, side2, side3;

        // method
        public void Inicializar() 
        {
            string line;
            //one
            Console.Write("Medida side 1");
            line = Console.ReadLine();
            side1 = int.Parse(line);
            //two
            Console.Write("Medida side 2");
            line = Console.ReadLine();
            side2 = int.Parse(line);
            //three
            Console.Write("Medida side 3");
            line = Console.ReadLine();
            side3 = int.Parse(line);
        }

        public void than() 
        {
            Console.Write("Side more big: ");

            if (side1 > side2 && side1 > side3)
            {
                Console.Write(side1 + " 1 ");

            }
            else 
            {
                if (side2 > side3)
                {
                    Console.Write(side2 + " 2 ");
                }
                else 
                {
                    Console.Write(side3 + " 3 ");
                }
            }
        }

        public void EsEquilatero() 
        {
            if (side1 == side2 && side1 == side3)
            {
                Console.Write("is a triangle equilatero");
            }
            else 
            {
                Console.Write("is not a triangle equilatero");
            }
        }

        static void Main(string[] args) 
        {
            Triangle triangle1 = new Triangle();
            triangle1.Inicializar();
            triangle1.than();
            triangle1.EsEquilatero();
            Console.ReadKey();
        }

    }
}
