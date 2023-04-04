using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sueldo;
            string linea;

            Console.Write("Ecribe el valor sueldo");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);

            if (sueldo > 3000) {
                Console.Write("Esta persona debe abonar impuestos");
            }
            Console.ReadKey();
        }
    }
}
