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

            Employee[] employees = new Employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("Anställd nr " + (i + 1));

                string name = AskForString("Name: ");
                int salary = AskForInt("Lön: ");

                employees[i] = new Employee(name, salary);
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Anställd nr " + Array.IndexOf(employees, employee));
                Console.Write(employee.Name.Length);
                Console.WriteLine(employee.Salary);
            }

        }

        private static int AskForInt(string prompt, string errorPrompt = "Felaktigt format, bara siffror får användas.")
        {
            int answer;
            bool success;
            do  // Repetera ...
            {
                string input = AskForString(prompt);

                #region try-catch
                // alternativ lösning
                //try
                //{
                //    salary = Convert.ToInt32(salaryString);
                //} catch (Exception e) {
                //    Console.WriteLine(e.Message + "\nFelaktigt format, lönen sätts till 0 kr");
                //}
                #endregion

                success = int.TryParse(input, out answer);
                if (!success)
                {
                    Console.WriteLine(errorPrompt);
                }
            } while (!success);  // ... så länge som vi inte har lyckats parsa strängen
            return answer;
        }

        private static string AskForString(string prompt)
        {
            Console.Write(prompt);
            string answer = Console.ReadLine();
            return answer;
        }
    }

    class Employee
    {
        public string Name;
        public int Salary;

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
