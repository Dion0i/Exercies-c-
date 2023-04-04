using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practica49
{
    class SearchVector 
    {
        private string[] name;
        private float[] salarys;

        public void Cargar() 
        {
            name = new string[5];
            salarys = new float[5];
            for (int f = 0; f < name.Length; f++) 
            {
                Console.Write("Write the name of the employer: ");
                name[f] = Console.ReadLine();
                Console.Write("Write the salary");
                string line;
                line = Console.ReadLine();
                salarys[f] = float.Parse(line);
            }
        }

        public void ThanSalary() 
        {
            float thant;
            int pos;
            thant = salarys[0];
            pos = 0;
            for (int f = 0; f < name.Length; f++) 
            {
                if (salarys[f] > thant) 
                {
                    thant = salarys[f];
                    pos = f;
                }
            }
            Console.WriteLine("The employer with saslary thant is: " + name[pos]);
            Console.WriteLine("has a salary: " +thant);
            Console.ReadKey();
        }

        static void Main(string[] args) 
        {
            SearchVector sv = new SearchVector();
            sv.Cargar();
            sv.ThanSalary();
        }

    }
}
