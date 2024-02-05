using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Schmo" },
                new Employee { Id = 2, FirstName = "John", LastName = "Wick" },
                new Employee { Id = 3, FirstName = "Luke", LastName = "Skywalker" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "King" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Jordan" },
                new Employee { Id = 6, FirstName = "Kylo", LastName = "Renn" },
                new Employee { Id = 7, FirstName = "Joe", LastName = "Momma" },
                new Employee { Id = 8, FirstName = "Christiano", LastName = "Ronaldo" },
                new Employee { Id = 9, FirstName = "Judah", LastName = "Kirkwood" },
                new Employee { Id = 10, FirstName = "Thom", LastName = "Yorke" }
            };

            // Listing Employees with the first name Joe's
            List<Employee> joesListForeach = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesListForeach.Add(employee);
                }
            }

            // Print the results using foreach loop
            Console.WriteLine("Employees with the first name 'Joe': ");
            foreach (var joeEmployee in joesListForeach)
            {
                Console.WriteLine($"ID: {joeEmployee.Id}, Name: {joeEmployee.FirstName} {joeEmployee.LastName}");
            }

            // Employees using LAMBDA with an Id number greater than 5
            List<Employee> highIdEmployeesLambda = employees.Where(emp => emp.Id > 5).ToList();

            // Print the results using lambda expression
            Console.WriteLine("\nEmployees with an ID greater than 5: ");
            foreach (var employee in highIdEmployeesLambda)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.ReadLine();
        }
    }
}

