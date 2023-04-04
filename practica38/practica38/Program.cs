using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica38
{
    class Employer 
    {
        private int salary;
        private string name;
        // Firts method
        public void Inicializar ()
        {
            string line;
            Console.Write("Write your name :");
            name = Console.ReadLine();
            Console.Write("Write your salary");
            line = Console.ReadLine();
            salary = int.Parse(line);
        }
        // Second method
        public void WriteValues() 
        {
            Console.Write("Name "+ name);
            Console.Write(" salary " + salary);
        }

        public void Impuestos() 
        {
            if (salary > 3000)
            {
                Console.Write("you must be pay impuestos");
            }
            else 
            {
                Console.Write("you not must be pay impuestos");
            }
        }

        static void Main(string[] args) 
        {
            Employer employer1 = new Employer();
            employer1.Inicializar();
            employer1.WriteValues();
            employer1.Impuestos();
            Console.ReadKey();

        }
    }
}
