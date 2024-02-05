using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee List
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

            // Using a foreach loop: Create a new list of all employees with the first name “Joe”
            List<Employee> joesList = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesList.Add(employee);
                }
            }

            // These are the results using foreach loop
            Console.WriteLine("Employees with the first name 'Joe': ");
            foreach (var joeEmployee in joesList)
            {
                Console.WriteLine($"ID: {joeEmployee.Id}, Name: {joeEmployee.FirstName} {joeEmployee.LastName}");
            }

            // Using LAMBDA making a "Joe" list
            List<Employee> joesListLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // These are the results using LAMBDA 
            Console.WriteLine("\nEmployees with the first name 'Joe': ");
            foreach (var joeEmployee in joesListLambda)
            {
                Console.WriteLine($"ID: {joeEmployee.Id}, Name: {joeEmployee.FirstName} {joeEmployee.LastName}");
            }

            // Employees using LAMBDA with an Id number greater than 5
            List<Employee> highIdEmployeesLambda = employees.Where(emp => emp.Id > 5).ToList();

            // Print the results using LAMBDA
            Console.WriteLine("\nEmployees with an ID greater than 5: ");
            foreach (var employee in highIdEmployeesLambda)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.ReadLine();
        }
    }
}
