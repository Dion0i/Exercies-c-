using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practica48
{
    class VectorParalelo 
    {
        private string[] names;
        private int[] age;

        public void Cargar() 
        {
            names = new string[5];
            age = new int[5];
            for (int f = 0; f < names.Length; f++) 
            {
                Console.Write("Write names: ");
                names[f] = Console.ReadLine();
                Console.Write("Write Age: ");
                string line;
                line = Console.ReadLine();
                age[f] = int.Parse(line);
            }
        }
        // End method

        private void ThantAge() 
        {
            Console.WriteLine("People more of age. ");
            for (int f = 0; f < names.Length; f++) 
            {
                if (age[f] >= 18) 
                {
                    Console.WriteLine(names[f]);
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args) 
        {
            VectorParalelo pv = new VectorParalelo();
            pv.Cargar();
            pv.ThantAge();
        }
    }  
}
