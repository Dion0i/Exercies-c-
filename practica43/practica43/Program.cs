using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica43
{
    class PruebaVector2 
    {
        private float[] alturas;
        private float promedio;

        public void Cargar() 
        {
            alturas = new float[5];
            for (int f = 0; f < 5; f++) 
            {
                Console.Write(" Ingres la altura de la persona : ");
                string line = Console.ReadLine();
                alturas[f] = float.Parse(line);
            }
        }
        //end
        public void CalcularPromedio() 
        {
            float sum;
            sum = 0;
            for (int f = 0; f < 5; f++) 
            {
                sum += alturas[f];
            }
            promedio = sum / 5;
            Console.WriteLine("Promedio de alturas: " + promedio);
        }
        // end
        public void MayoresMenores() 
        {
            int may, men;
            may = 0;
            men = 0;

            for (int f = 0; f < 5; f++) 
            {
                if (alturas[f] > promedio)
                {
                    may++;
                }
                else 
                {
                    if (alturas[f] < promedio) 
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio : " + may);
            Console.WriteLine("Cantidad de personas menores al promedio : " + men);
            Console.ReadKey();
        }

        static void Main(string[] args) 
        {
            PruebaVector2 pv2 = new PruebaVector2();
            pv2.Cargar();
            pv2.CalcularPromedio();
            pv2.MayoresMenores();
        }

    }
}
