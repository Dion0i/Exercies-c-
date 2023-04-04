using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica46
{
    class PruebaVector 
    {
        private int[] salary;

        public void Cargar() 
        {
            Console.Write("How many salaries changes");
            string line;
            line = Console.ReadLine();
            int cant = int.Parse(line);
            salary = new int[cant];            

            // end console

            for (int f = 0; f < salary.Length; f++) 
            {
                Console.Write("Write your Salary : ");
                line = Console.ReadLine();
                salary[f] = int.Parse(line);
            }
        }
        // End method

        public void PrintV() 
        {
            for (int f = 0; f < salary.Length; f++) 
            {
                Console.WriteLine(salary[f]);
            }
            Console.ReadKey();
        }
        // End method

        // Start static void 
        static void Main(string[] args) 
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.PrintV();
        }

    }
}
