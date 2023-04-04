using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, suma, producto;
            string linea;

            Console.Write("Ingrese su primer valor");
            linea = Console.ReadLine();
            n1 = int.Parse(linea);
            Console.Write("Ingrese su segundo valor");
            linea = Console.ReadLine();
            n2 = int.Parse(linea);
            Console.Write("Ingrese su tercer valor");
            linea = Console.ReadLine();
            n3 = int.Parse(linea);
            Console.Write("Ingrese su cuarto valor");
            linea = Console.ReadLine();
            n4 = int.Parse(linea);

            suma = n1 + n2;
            producto = n3 * n4;

            Console.Write("El valor de la suma es: ");
            Console.WriteLine(suma);
            Console.Write("El valor del prodicto es: ");
            Console.Write(producto);
            Console.ReadKey();

        }
    }
}
