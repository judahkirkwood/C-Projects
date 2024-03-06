using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkFinal;

namespace EntitiyFrameworkFinal
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                context.Database.EnsureCreated();

                var newStudent = new Student { Name = "John Doe", Age = 20 };
                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");

                Console.WriteLine("All students:");
                var students = context.Students.ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Add a new student
                var newStudent = new Student { Name = "John Doe", Age = 20 };
                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");

                // Display all students
                Console.WriteLine("All students:");
                var students = context.Students.ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
