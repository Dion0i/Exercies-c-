using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica40
{
    class TablaMultiplicar
    {
        public void CargaValor() 
        {
            int value;
            string line;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar) : ");
                line = Console.ReadLine();
                value = int.Parse(line);
                if (value != -1)
                {
                    Calcular(value); // llamada al metodo (donde value le pasa un valor a calcular);
                }
            } while (value != -1);
        }

        public void Calcular(int v) // calcular toma el valolr  de value en el parametro.
        {
            for (int f = v; f <= v * 10; f += v) 
            {
                Console.Write(f+ "_");
            }
            Console.WriteLine(); // salto de linea.
        }

        static void Main(string[] args) 
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.CargaValor();
        }
    } 
}
