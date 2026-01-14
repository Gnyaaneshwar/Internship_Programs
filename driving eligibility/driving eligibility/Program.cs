using System.ComponentModel.Design;

//string name = null;
string[] names = new string[5];
string[] genders = new string[5];
int[] ages = new int[5];
bool[] eligibility= new bool[5];
for (int i = 1; i <=3; i++)
{
    Console.WriteLine("\nstudent:" + i);
    while (true)
    {
        Console.WriteLine(" Student Name");
       string name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("the name is invalid");
        }
        else
        {
            names[i] = name;
            break;
        }
    }

    
   
    //Console.WriteLine("gender");
    //gender = Console.ReadLine();
    //if (gender != "male" && gender != "female")
    //{
    //    Console.WriteLine("invalid gender");
    //}

    while (true)
    {
        Console.WriteLine("gender");
       string gender = Console.ReadLine();
        if (gender.ToLower() != "male" && gender != "female")
        {
            Console.WriteLine("invalid gender");
        }
        else
        {
            genders[i] = gender;
            break;
        }
    }
    int age;
    while (true)
    {
        Console.WriteLine(" Age ");
        string ageinput = Console.ReadLine();
        if (!int.TryParse(ageinput, out age))
        {
            Console.WriteLine(" age should be in digits");
        }
        else
        {
            ages[i] = age;
            eligibility[i] = age >= 18;
            break;
        }
    }
}
Console.WriteLine("\n Results");      
for (int i = 1;i < 4;i++) 
{
    Console.WriteLine($"Student {i}: {names[i]}, Gender: {genders[i]}, Age: {ages[i]}");
    if (eligibility[i])
    {
        Console.WriteLine("This student is eligible for driving");
    }
    else
    {
        Console.WriteLine(" This student is not eligible for driving");
    }

}

    

