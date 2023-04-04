using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salary, yearAnt, pluss;
            string line;

            Console.WriteLine("write the sum of your salary");
            line = Console.ReadLine();
            salary = float.Parse(line);
            // Salary
            Console.WriteLine("what is your time here?");
            line = Console.ReadLine();
            yearAnt = float.Parse(line);
            // Old time

            if (salary < 500 && yearAnt >= 10)
            {
                pluss = (float)(salary * 1.20);
                Console.Write("The salary is" + pluss);
            }
            else 
            {
                if (salary < 500 && yearAnt < 10)
                {
                    pluss = (float)(salary * 1.05);
                    Console.Write("The salary is" + pluss);
                }
                else 
                {
                    if (salary >= 500) 
                    {
                        Console.Write("The salary is" + salary);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
