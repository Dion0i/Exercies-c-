using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica47
{
    class PracticaV 
    {
        private int[] elements;
        public void Cargar() 
        {
            Console.Write("Write your cant of elements : ");
            string line;
            line = Console.ReadLine();
            int cant = int.Parse(line);
            elements = new int[cant];
            // Here write the cant of values
            for (int f = 0; f < elements.Length; f++) 
            {
                Console.Write("Write your numbers");
                line = Console.ReadLine();
                elements[f] = int.Parse(line);
            }
        }
        // End method

        public void PrintV() 
        {
            int sum = 0;
            for (int f = 0; f < elements.Length; f++) 
            {
                
                sum += elements[f];
            }

            Console.WriteLine("Here all : " + sum);
        }

        static void Main(string[] args) 
        {
            PracticaV pv = new PracticaV();
            pv.Cargar();
            pv.PrintV();
            Console.ReadKey();
        }

    }
}
