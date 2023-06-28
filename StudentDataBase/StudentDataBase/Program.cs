using StudentDataBase;
using System;

namespace StudentDataBase
{
    internal class Program
    {
        //Create a basic Entity Framework Code-First console application that creates a basic Student database and adds one student.

        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Student added...");
            Console.ReadLine();
        }
    }
}