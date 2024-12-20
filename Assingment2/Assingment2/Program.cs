using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
       

        class Student
        {
            // Define properties for the Student class
            public string Name { get; set; }
            public int Age { get; set; }
            public double Grade { get; set; }
        }

        static void Main(string[] args)
        {
            


            Student[] students = new Student[5];

            // Collect data for each student
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                Console.WriteLine($"Enter Details for Student {i + 1}");
                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                students[i].Age = int.Parse(Console.ReadLine());

                Console.Write("Grade: ");
                students[i].Grade = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            // Display data for all students
            Console.WriteLine("Details of All Students:\n");


            int count = 1; // To keep track of student numbers
            foreach (var student in students)
            {
                Console.WriteLine($"Student {count++}:");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Grade: {student.Grade}");
               

                string status = student.Grade >= 50 ? "Pass" : "Fail";
                Console.WriteLine($"Status: {status}");

                Console.WriteLine();
            }
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Student {i + 1}:");
            //    Console.WriteLine($"Name: {students[i].Name}");
            //    Console.WriteLine($"Age: {students[i].Age}");
            //    Console.WriteLine($"Grade: {students[i].Grade:F2}"); // Display grade with 2 decimal places
            //    Console.WriteLine();
            //}

           

           

            Console.ReadLine(); // Pause the console before closing
        }
    }
}