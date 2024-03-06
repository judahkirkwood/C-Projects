using StudentDb.Models;
using System.Data.Entity;
using System;
using System.Diagnostics;

namespace StudentDb 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}

