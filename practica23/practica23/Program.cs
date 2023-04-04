using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            int alumn;
            string line;
            int acum1 = 0;
            int acum2 = 0;
            int x = 1;

            while (x <= 10)
            {
                Console.Write("Digit your value");
                line = Console.ReadLine();
                alumn = int.Parse(line);


                if (alumn >= 7)
                {
                    acum1 += 1;
                }
                else
                {
                    acum2 += 1;
                }
                x += 1;
            }
            Console.Write("alumns: ");
            Console.WriteLine(acum1);
            // lines
            Console.Write("This alumns: ");
            Console.WriteLine(acum2);



            Console.ReadKey();
        }
    }
}
