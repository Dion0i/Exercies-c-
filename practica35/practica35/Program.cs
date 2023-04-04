using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practica35
{
    class person
    {
        private string name;
        private int age;

        // it's a method
        public void Inicializar()
        {
            Console.Write("Write your name");
            name = Console.ReadLine();
            string line;
            Console.Write("Write your age");
            line = Console.ReadLine();
            age = int.Parse(line);   
        }
        // it's a method
        public void Imprimir() 
        {
            Console.Write("Name: ");
            Console.WriteLine(name);
            Console.Write("Age: ");
            Console.WriteLine(age);
        }
        // it's a method
        public void ThanPlus() 
        {
            if (age >= 18)
            {
                Console.Write("he/she is a big person");
            }
            else 
            {
                Console.Write("Not is a big person");
            }
            Console.ReadKey();
        }

        static void Main(string[] args) 
        {
            person per1 = new person();
            per1.Inicializar();
            per1.Imprimir();
            per1.ThanPlus();
        }

    }

    
}
