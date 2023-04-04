using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica45
{
    class Vector4 
    {
        private int[] vect1;
        private int[] vect2;
        private int[] SumVectores;
        public void CargaElement() 
        {
            vect1 = new int[4];         
            string line;

            for (int f = 0; f < 4; f++) 
            {
                Console.WriteLine("Write yours values (1) : ");
                line = Console.ReadLine();
                vect1[f] = int.Parse(line);
            }
        }
        // end
        public void sumElement()
        {
            int sum = 0;
            for (int f = 0; f < 4; f++)
            {
                sum += vect1[f];
            }
            // Firts
        }
        // end
        public void CargaElement2()
        {
            vect2 = new int[4];
            string line;

            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("Write yours values (2) : ");
                line = Console.ReadLine();
                vect2[f] = int.Parse(line);
            }

        }  
        // end
        public void sumElement2()
        {
            int sum2 = 0;
            for (int f = 0; f < 4; f++)
            {
                sum2 += vect2[f];
            }
            // Second
        }

        public void SumV() 
        {
            SumVectores = new int[4];
            int Result = 0;

            for (int f = 0; f < 4; f++) 
            {
                Result = vect1[f] + vect2[f];

                Console.WriteLine("The results of the values : " + Result);
            }
        }

        static void Main(string[] args) 
        {
            Vector4 vt4 = new Vector4();
            vt4.CargaElement();
            vt4.CargaElement2();
            vt4.sumElement();
            vt4.sumElement2();
            vt4.SumV();
            Console.ReadKey();
        }

    }
}
