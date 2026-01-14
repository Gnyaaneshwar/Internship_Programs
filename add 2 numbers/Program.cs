using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static int add(int a, int b)
    {
        return a + b;
    }
    static void Main()

    {
        Console.WriteLine("--------addding two numbers-----------");
        int num1, num2;
        while (true)
        {
            Console.WriteLine("enter the value of number 1");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                break;
            }
        }
        while (true)
        {
            Console.WriteLine("enter the value of number 2");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("invalid number");
            }
            else
            {
               break ;
            }
        }
        
            int result = add(num1, num2);
            Console.WriteLine("sum =" + result);
        
        
    }
}

        
        
          
        
        
       
        
        
