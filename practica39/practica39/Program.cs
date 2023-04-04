using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica39
{
    class Operation
    {
        private int num1, num2;
        private float sum, rest, mult, divd;

        // Firt method
        public void Initializar()
        {
            string line;
            Console.Write("Write your firts number");
            line = Console.ReadLine();
            num1 = int.Parse(line);
            // Number two
            Console.Write("Write your second number");
            line = Console.ReadLine();
            num2 = int.Parse(line);
        }
        // second method
        public void SumValues()
        {
            sum = num1 + num2;            
        }
        // third method
        public void RestValues()
        {
            rest = num1 - num2;            
        }
        // fourth

        public void MultValues()
        {
            mult = num1 * num2;
        }

        public void DivdtValues()
        {
            divd = num1 / num2;
        }

        public void PrintValues()
        {
            Console.Write(" suma " + sum);
            Console.Write(" resta " + rest);
            Console.Write(" multipication " + mult);
            Console.Write(" division " + divd);
        }

        // method main
        static void Main(string[] args) 
        {
            Operation operation1 = new Operation();
            operation1.Initializar();
            operation1.SumValues();
            operation1.RestValues();
            operation1.MultValues();
            operation1.DivdtValues();
            operation1.PrintValues();
            Console.ReadKey();
        }

    }
}
