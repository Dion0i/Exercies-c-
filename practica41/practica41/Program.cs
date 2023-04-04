using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica41
{
    class PlussLess
    {
        public void CargarValores()
        {
            string line;
            Console.Write("Write your first value");
            line = Console.ReadLine();
            int val1 = int.Parse(line);
            // Two 
            Console.Write("Write your second value");
            line = Console.ReadLine();
            int val2 = int.Parse(line);
            // Third
            Console.Write("Write your first value");
            line = Console.ReadLine();
            int val3 = int.Parse(line);

            int pluss, less;

            pluss = CalcularMayor(val1, val2, val3);
            less = CalcularMenor(val1, val2, val3);
            Console.WriteLine("El valor mayor de los tres es: " + pluss);
            Console.WriteLine("El valor menor de los tres es: " + less);
        }

        public int CalcularMayor(int v1, int v2, int v3) 
        {
            int m;
            if (v1 > v2 && v1 > v3)
            {
                m = v1;
            }
            else 
            {
                if (v2 > v3)
                {
                    m = v2;
                }
                else 
                {
                    m = v3;
                }
            }
            return m;
        }

        public int CalcularMenor(int v1, int v2, int v3)
        {
            int m;
            if (v1 < v2 && v1 < v3)
            {
                m = v1;
            }
            else
            {
                if (v2 < v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        static void Main(string[] args) 
        {
            PlussLess mm = new PlussLess();
            mm.CargarValores();
            Console.ReadKey();
        }
    }
}
