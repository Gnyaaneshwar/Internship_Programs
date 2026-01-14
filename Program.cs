
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Dictionary<int, string> datachecking = new Dictionary<int, string>()

        {
            { 33,"hardik"},
            { 45,"rohit"},
            { 63,"surya"},
            { 18,"kohli"}
        };
        Console.WriteLine("\n datachecking list");
        Console.WriteLine("\n --------------------------");
        foreach(var student in datachecking)
        {
            Console.WriteLine($"{student.Key,-20}:{student.Value,10}");
        }
        while (true)
        {
            Console.WriteLine("\n Enter the roll number");
            if (int.TryParse(Console.ReadLine(), out int rollno))
            {
                Console.WriteLine("\n enter the student name");
                string name = Console.ReadLine();
                if (datachecking.ContainsKey(rollno))
                {
                    if (datachecking[rollno].Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Student found {datachecking[rollno]}");
                    }
                    else
                    {
                        Console.WriteLine($"mistmatching id {datachecking[rollno]}");
                    }
                }
                else
                {
                    datachecking.Add(rollno, name);
                    Console.WriteLine($" new student added :  name : {name}, roll no : {rollno}");
                    break;
                }
            }

            else
            {
                Console.WriteLine(" invalid roll number ");

            }
        }

        Console.WriteLine("\n--------student list---------");
        Console.WriteLine("{0,-20} {1,20}", "rollno", "name" );
        Console.WriteLine(new string('-', 30));

        foreach (var student in datachecking)
        {
            Console.WriteLine($"{student.Key,-15} : {student.Value,15}");
        }
    }
}





















