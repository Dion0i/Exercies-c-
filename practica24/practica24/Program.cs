using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practica24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employers, salary, imprt;
            string line;
            int acum = 0;
            int acum1 = 0;
            int acm = 0;
            int x = 1;

            Console.Write("How employers there are ?");
            line = Console.ReadLine();
            employers = int.Parse(line);

            while (x <= employers) 
            {
                Console.Write("The salary is: ");
                line = Console.ReadLine();
                salary = int.Parse(line);

                if (salary >= 100 && salary <= 300)
                {
                    acum += 1;
                }
                else 
                {
                    if (salary > 300) 
                    {
                        acum1 += 1;
                    }
                }
                acm += salary;
                x += 1;
            }
            imprt = employers * acm;
            Console.Write("The salary <300: " );
            Console.WriteLine(acum);

            Console.Write("The salary >300: ");
            Console.WriteLine(acum1);
            
            Console.Write("The import is: ");
            Console.WriteLine(imprt);

            Console.ReadKey();  
        }
    }
}
