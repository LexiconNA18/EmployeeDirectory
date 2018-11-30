using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDirectory
{
    class Payroll
    {
        private List<Employee> employees = new List<Employee>();
        
        public void Add(string name, int salary)
        {
            employees.Add(new Employee(name, salary));
        }

        public Employee[] GetEmployees()
        {
            return employees.ToArray();
        }

        public Employee GetEmployeeByName(string name)
        {
            foreach (Employee employee in employees)
            {
                string query = name.ToLower().Trim();
                if (employee.Name.ToLower().Contains(query)) {
                    return employee;
                }           
            }
            return null;
        }

        public List<Employee> GetEmployeesWithSalary(int min) {
            var list = new List<Employee>();
            foreach (var employee in employees) {
                if (employee.Salary >= min) {
                    list.Add(employee);
                }
            }
            return list;
        }
    }
}