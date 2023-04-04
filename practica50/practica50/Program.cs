using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace practica50
{
    class VectorMenor 
    {
        private int[] menor;
        int cant, value;
        public void Cargar() 
        {
            
            string line;
            Console.WriteLine("Write cant: ");
            line = Console.ReadLine();
            cant = int.Parse(line);
            menor = new int[cant];
            for (int f = 0; f < cant; f++) 
            {
                Console.Write("Write your values");
                line = Console.ReadLine();
                value = int.Parse(line);
                menor[f] = value;
            }
        }
        // End method

        public void Operation() 
        {
            float less, repit;
            repit = 0;
            less = menor[0];
            for (int f = 0; f < cant; f++) 
            {
              
                if (menor[f] < less)
                {
                    less = menor[f];
                }t

                if (menor[f] == less) 
                {
                    repit = menor[f];
                }
            }

            Console.WriteLine("the less of the all value is: " +less);
            Console.Write("It's values are: " + repit);
        }

        static void Main(string[] args) 
        {
            VectorMenor vt = new VectorMenor();
            vt.Cargar();
            vt.Operation();
            Console.ReadKey();
        }
    }
}
