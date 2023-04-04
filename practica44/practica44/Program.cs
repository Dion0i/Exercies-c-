using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica44
{
    class Vector3
    {
        private int[] VectorAcm;

        public void CargarNum()
        {
            VectorAcm = new int[8];
            Console.WriteLine("Here nums : ");
            string line;
            for (int f = 0; f < 8; f++)
            {
                Console.Write("Write his values");
                line = Console.ReadLine();
                VectorAcm[f] = int.Parse(line);
            }
        }
        //end
        public void Operations()
        {
            int sum = 0;       
            for (int f = 0; f < 8; f++)
            {
                sum += VectorAcm[f];
            }
            Console.WriteLine("All values : " + sum);
        }

        // end
        public void ElementIf()
        {
           int sum2 = 0;
           
            for (int y = 0; y < 8; y++)
            {
                if (VectorAcm[y] > 36)
                {
                    sum2 += VectorAcm[y];
                }
            }
            Console.WriteLine("Values than 36 : " + sum2);
        }

        // end
        public void ElementIf2() 
        {
            int sum3 = 0;
            for (int y = 0; y < 8; y++)
            {
                if (VectorAcm[y] > 50)
                {
                    sum3++;
                }
            }

            Console.WriteLine("CANT thant 50 : " + sum3);
        }
        //// end

        static void Main(string[] args) 
        {
            Vector3 vt3 = new Vector3();
            vt3.CargarNum();
            vt3.Operations();
            vt3.ElementIf();
            vt3.ElementIf2();
            Console.ReadKey();
        }

    }
}
