using System;
using System.Collections.Generic;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<Employee> employees = new List<Employee>();
            Dictionary<string, double> sortedDepartments = new Dictionary<string, double>();
            double allSalary = 0.00;
            double firstSalary = 0.00;
            int counter = 1;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] tokens = input.Split();

                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string department = tokens[2];

                Employee employee = new Employee()
                {
                    Name = name,
                    Salary = salary,
                    Department = department,
                };
                employees.Add(employee);

                if (sortedDepartments.ContainsKey(department))
                {
                    sortedDepartments[department] += salary;


                    counter++;
                }
                else
                {
                    sortedDepartments.Add(department, employee.Salary);
                }
            }

        }
        static Employee GetSalary(List<Employee> employees, string department, double salary)
        {
            Employee averageSalary = null;



            foreach (Employee employee in employees)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    averageSalary = employee;
                }
            }
            return averageSalary;
        }


        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Department { get; set; }
        }
    }
}
