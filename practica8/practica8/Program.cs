using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;

            Console.Write("Ingrese primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                Console.Write("Mayor: ");
                Console.WriteLine(num1);
            }
            else {
                Console.Write("Mayor");
                Console.WriteLine(num2);
            }
            Console.ReadKey();
        }
    }
}
