using System;
class Program
{
    static int FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;

    }

    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("\n enter the 5 values");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("\n value " + (i + 1) + ":");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n entered values");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
        }
        int max = FindMax(numbers);
        Console.WriteLine("\n the maximum value of num  is " + max);
    }

}