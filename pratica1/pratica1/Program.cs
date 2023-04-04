using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaTrabajadas;
            float costoHora;
            float sueldo;
            string linea;
            
            Console.Write("Ingrese horas trabajadas por el operario");
            linea = Console.ReadLine( );
            horaTrabajadas = int.Parse(linea);
            Console.Write("Ingrese el pago por hora");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            sueldo = horaTrabajadas * costoHora;
            Console.Write("El sueldo total del operario es: ");
            Console.Write(sueldo);
            Console.ReadKey( );
        }
    }
}
