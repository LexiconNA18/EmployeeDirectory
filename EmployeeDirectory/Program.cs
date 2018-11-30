using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            Payroll payroll = new Payroll();

            payroll.Add("Joe Bloggs", 10000);
            payroll.Add("Eva Lu Ator", 47110);
            payroll.Add("Anna", 15000);
            payroll.Add("Bertil", 28000);
            payroll.Add("Cecila", 22500);

            Console.WriteLine("\nMata in anställda, avsluta med tomt namn.");
            while (true)
            {
                Console.WriteLine();

                string name = Util.AskForString("Name: ");
                if (name == "")
                {
                    break;
                }
                int salary = Util.AskForInt("Lön: ");

                payroll.Add(name, salary);
            }


            Console.WriteLine("\nAnställda:");
            int j = 1;
            foreach (Employee employee in payroll.GetEmployees())
            {
                Console.WriteLine(j + ": " + employee);
                j++;
            }

            Console.WriteLine("\nSök efter anställd");
            string queryName = Util.AskForString("Ange namn: ");
            Employee byName = payroll.GetEmployeeByName(queryName);
            Console.WriteLine(byName);

            Console.WriteLine("\nLista efter lönenivå");
            int minSalary = Util.AskForInt("Ange lönenivå: ");
            foreach (var employee in payroll.GetEmployeesWithSalary(minSalary))
            {
                Console.WriteLine(employee);
            }

        }
    }
}
