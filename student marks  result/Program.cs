using System;
class program
{
    const float passingmarks = 40f;

    static float CalculateAverage(int[] marks)
    {
        int sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }
        float FinalMark = sum / marks.Length;
        return FinalMark;
    }

    static void Main()
    {
        Dictionary<int, (string name, int[] marks)> students = new Dictionary<int, (string name, int[] marks)>();

        int count;
        while (true)
        {
            Console.WriteLine("\n how many students ?");
            if (int.TryParse(Console.ReadLine(), out count) & count > 0)
                break;
            Console.WriteLine("invalid input");
        }

        for (int j = 0; j < count; j++)
        {
            Console.WriteLine($"\n student{j + 1} details");
            string name;
            while (true)
            {
                Console.WriteLine("\n enter your name");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                Console.WriteLine("Name cannot be empty. Try again.");
            }
            int roll;
            while (true)
            {
                Console.Write("Enter roll number: ");
                if (int.TryParse(Console.ReadLine(), out roll) && roll > 0)
                {
                    if (!students.ContainsKey(roll))
                        break;
                    else
                        Console.WriteLine("Roll number already exists. Enter a unique roll number.");
                }
                else
                {
                    Console.WriteLine("Invalid roll number. Please enter a positive integer.");
                }
            }
            int[] marks = new int[3];
            for (int i = 0; i < marks.Length; i++)
            {
                    while (true)
                    {
                        Console.Write($"enter mark for subject {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out marks[i]) && marks[i] >= 0 && marks[i] <= 100)
                            break;
                        Console.WriteLine("invalid mark. Please enter a number between 0 and 100");
                    }

            }

                students[roll] = (name, marks);
        }

        Console.WriteLine(" student result details ");
        Console.WriteLine($"passing threshold {passingmarks}");

        foreach (var entry in students)
        {
            int roll = entry.Key;
            string name = entry.Value.name;
            int[] marks = entry.Value.marks;

            float average = CalculateAverage(marks);
            bool IsPass = average >= passingmarks;


            Console.WriteLine($"\n roll no : {roll} ");
            Console.WriteLine($"\n name : {name} ");
            Console.WriteLine($"\n marks : {marks[0]} , {marks[1]} , {marks[2]}");
            Console.WriteLine($"\n average : {average:F2} ");
            Console.WriteLine($"\n result :  {(IsPass ? "pass" : "fail")}");
        }
    }

}







        
