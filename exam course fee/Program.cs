
using System;

namespace FinalCourseFee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input. Enter a positive number of students: ");
            }

            // Arrays 
            int[] coursefees = new int[n];
            double[] percentages = new double[n];
            DateTime[] dates = new DateTime[n];

            // inputs
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1} ");

                // Course fee
                Console.Write("Enter the original course fee: ");
                while (!int.TryParse(Console.ReadLine(), out coursefees[i]) || coursefees[i] <= 0)
                {
                    Console.Write("Invalid input. Enter a positive number: ");
                }

                // Academic percentage
                Console.Write("Enter the academic percentage: ");
                while (!double.TryParse(Console.ReadLine(), out percentages[i]) || percentages[i] < 0 || percentages[i] > 100)
                {
                    Console.Write("Invalid input. Enter a number between 0 and 100: ");
                }
                
                // Registration date
                Console.Write("Enter the registration date (dd-mm-yyyy): ");
                while (!DateTime.TryParse(Console.ReadLine(), out dates[i]))
                {
                    Console.Write("Invalid input. Enter a valid date (dd-mm-yyyy): ");
                }
            }

            // results
            Console.WriteLine("\n--- Final Results 1 ---");
            for (int i = 0; i < n; i++)
            {
                double discount = 0;

                // Discounts
                if (percentages[i] >= 90)
                    discount = 0.30;
                else if (percentages[i] >= 75)
                    discount = 0.20;
                else if (percentages[i] >= 60)
                    discount = 0.10;

                // Extra discount 
                if ((DateTime.Now - dates[i]).TotalDays <= 15)
                    discount += 0.05;

                // Finalcoursefee
                double finalcourseFee = coursefees[i] - (coursefees[i] * discount);

                //  results
                Console.WriteLine($"\nStudent {i + 1}:");
                Console.WriteLine("Original course fee: ₹" + coursefees[i].ToString("N0"));
                Console.WriteLine("Total discount: " + (discount * 100) + "%");
                Console.WriteLine("Final payable fee: ₹" + finalcourseFee.ToString("N0"));
            }

            
        }
    }
}











