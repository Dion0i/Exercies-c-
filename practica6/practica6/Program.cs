using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int articulo, cantidad, abono;
            string linea;

            Console.Write("Escribe el precio del articulo");
            linea = Console.ReadLine();
            articulo = int.Parse(linea);
            Console.Write("Escribe la cantidad del articulo");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            abono = articulo * cantidad;

            Console.Write("El abono que debe hacer es de: ");
            Console.WriteLine(abono);
            Console.ReadKey();

        }
    }
}
