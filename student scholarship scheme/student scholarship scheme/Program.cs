using System.ComponentModel.Design;
// using array to store information
string[] names = new string[3];
int[] marks = new int[3];
int[] incomes = new int[3];
bool[] eligibilityofmark = new bool[3];
bool[] eligibilityofincome = new bool[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\nStudent : {i + 1}");
    while (true)
    {
        Console.WriteLine(" student name");
        string name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine(" the name is invalid");
        }
        else
        {
            names[i] = name;
            break;
        }
    }
    int mark;
    while (true)
    {
        Console.WriteLine(" your mark");

        string markinput = Console.ReadLine();
        if (!int.TryParse(markinput, out mark))
        {
            Console.WriteLine("ivalid. enter digits");
        }
        else
        {
            marks[i] = mark;
            eligibilityofmark[i] = mark >= 85;
            break;
        }
    }
    int income;
    while (true)
    {
        Console.WriteLine(" your Annual income");
        string incomeinput = Console.ReadLine();
        if (!int.TryParse(incomeinput, out income))
        {
            Console.WriteLine(" invalid . please enter in digits format");
        }
        else
        {
            incomes[i] = income;
            eligibilityofincome[i] = income < 200000;
            break;
        }
    }
}

    Console.WriteLine(" eligibility status for scholarship");

for (int j = 0; j < 3; j++)

{
    Console.WriteLine($"Student {j + 1}: {names[j]}, marks: {marks[j]}, income: {incomes[j]}");
        if (eligibilityofmark[j] && eligibilityofincome[j])
        {
            Console.WriteLine("This student is eligible for scholarship");
        }
        else
        {
            Console.WriteLine(" This student is not eligible for scholarship");
        }
 }

