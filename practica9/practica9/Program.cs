using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum, differ, product, divction;
            string line;

            Console.Write("Write your firts number");
            line = Console.ReadLine();
            n1 = int.Parse(line);
            Console.Write("Write your second number");
            line = Console.ReadLine();
            n2 = int.Parse(line);

            if (n1 > n2)
            {
                sum = n1 + n2;
                differ = n1 - n2;
                Console.Write("The sum is: ");
                Console.WriteLine(sum);
                Console.Write("The differ is: ");
                Console.WriteLine(differ);
            }
            else {
                product = n1 * n2;
                divction = n1 / n2;
                Console.Write("The product is: ");
                Console.WriteLine(product);
                Console.Write("The divction is: ");
                Console.WriteLine(divction);
            }
            Console.ReadKey();

        }
    }
}
