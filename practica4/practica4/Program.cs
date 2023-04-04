using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;

            Console.Write("Digite valor");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("El perimetro es: ");
            Console.Write(perimetro);
            Console.ReadKey();
        }
    }
}
