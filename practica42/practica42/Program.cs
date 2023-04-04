using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica42
{
    class PruebaVector1 
    {
        private int[] sueldos;

        public void Cargar() 
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++) 
            {
                Console.Write("Ingrese valor de la componente :");
                string line;
                line = Console.ReadLine();
                sueldos[f] = int.Parse(line);
            }
        }
        // end
        public void Imprimir() 
        {
            for (int f = 0; f < 5; f++) 
            {
                Console.WriteLine("");
                Console.Write(sueldos[f]);
            }
            Console.ReadKey();
        }
        // end

        static void Main(string[] args) 
        {
            PruebaVector1 pv = new PruebaVector1();
            pv.Cargar();
            pv.Imprimir();
        }
    } 
}
