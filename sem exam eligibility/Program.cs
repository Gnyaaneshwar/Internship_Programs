
using System;

namespace ExamEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // how many students 
            Console.Write("Enter the number of students: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input. Enter a positive number of students: ");
            }

            // Arrays 
            double[] attendances = new double[n];
            double[] marks = new double[n];

            // all inputs
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n Enter details for Student {i + 1} ");

                // Attendance input
                Console.Write("enter the student's attendance percentage (0-100): ");
                while (!double.TryParse(Console.ReadLine(), out attendances[i]) || attendances[i] < 0 )
                {
                    Console.Write("Invalid input. Enter a number between 0 and 100: ");
                }

                // Internal marks input
                Console.Write("Enter the student's internal marks (0-100): ");
                while (!double.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 0 )
                {
                    Console.Write("Invalid input. Enter a number between 0 and 100: ");
                }
            }

            // results
            Console.WriteLine("\n Eligibility Results ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                if (attendances[i] >= 75 && marks[i] >= 40)
                {
                    Console.WriteLine(" Eligible for Exam");
                }
                else
                {
                    Console.WriteLine(" Not Eligible for Exam");
                    if (attendances[i] < 75 && marks[i] < 40)
                        Console.WriteLine("Reason - Low attendance and low internal marks.");
                    else if (attendances[i] < 75)
                        Console.WriteLine("Reason - Low attendance.");
                    else
                        Console.WriteLine("Reason - Low internal marks.");
                }
            }

           
        }
    }
}