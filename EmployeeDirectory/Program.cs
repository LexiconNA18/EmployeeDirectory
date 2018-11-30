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

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Anställd nr " + (i + 1));

                string name = AskForString("Name: ");

                // Det här vore trevligt:
                // int salary = AskForInt("Lön: ");

                int salary;
                bool success;
                do  // Repetera ...
                {
                    string salaryString = AskForString("Lön: ");

                    #region try-catch
                    //try
                    //{
                    //    salary = Convert.ToInt32(salaryString);
                    //} catch (Exception e) {
                    //    Console.WriteLine(e.Message + "\nFelaktigt format, lönen sätts till 0 kr");
                    //}
                    #endregion

                    success = int.TryParse(salaryString, out salary);
                    if (!success)
                    {
                        Console.WriteLine("Felaktigt format, bara siffror får användas.");
                    }
                } while (!success);  // ... så länge som vi inte har lyckats parsa lönen



                Employee employee = new Employee();
                employee.Name = name;
                employee.Salary = salary;

                employees[i] = employee;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Anställd nr " + (i + 1));
                Console.WriteLine(employees[i].Name);
                Console.WriteLine(employees[i].Salary);
            }
            
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
    }
}
