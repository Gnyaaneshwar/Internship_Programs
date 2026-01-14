// -----------multiplication table------------

using multiplication_table;


//while (true)
//{
//    Console.WriteLine("\n enter any one number ");
//    string input = Console.ReadLine();
//    if (int.TryParse(input, out int number))
//    {
//        Console.WriteLine($"\n mutiplication table {number}: ");
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"{number} * {i} = {number * i}");
//        }
//        break;
//    }
//    else
//    {
//        Console.WriteLine("invalid input . please enter a valid number.");
//    }
//}

// -------------------vowels count --------------------------

//using System.ComponentModel.Design;
//while (true)
//{
//    Console.WriteLine("\n enter anyword");
//    string word = Console.ReadLine();
//    if (string.IsNullOrEmpty(word))
//    {
//        Console.WriteLine("invalid . enter in letters");
//    }
//    else
//    {
//        int vowelCounts = 0;

//        foreach (char ch in word.ToLower())
//        {
//            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//            {
//                vowelCounts++;
//            }
//        }
//        Console.WriteLine($"the word \"{word}\" has {vowelCounts} vowels");
//        break;
//    }
//}



// -----------------using array to store marks------------------------------


//int[] marks = new int[5];

//for (int i = 0; i < marks.Length; i++)
//{
//    Console.WriteLine($"\nEnter the subject {i + 1} marks:");
//    string input = Console.ReadLine();

//    if (!int.TryParse(input, out int mark) || mark < 0 || mark > 100)
//    {
//        Console.WriteLine("Invalid.");
//        marks[i] = 0;
//    }
//    else
//    {
//        marks[i] = mark;

//    }
//}

//Console.WriteLine("\n------ Subject Marks ------");
//for (int i = 0; i < marks.Length; i++)
//{
//    Console.WriteLine($"Subject {i + 1}: {marks[i]}");
//}

////  Average

//int sum = 0;
//foreach (int m in marks) sum += m;
//double average = (double)sum / marks.Length;
//Console.WriteLine($"\nAverage marks: {average}");

////: Highest
//int highest = marks[0];
//foreach (int m in marks) if (m > highest) highest = m;
//Console.WriteLine($"Highest mark: {highest}");

////  Even/Odd

//int evenCount = 0, oddCount = 0;
//foreach (int m in marks)
//{
//    if (m % 2 == 0) evenCount++;
//    else oddCount++;
//}
//Console.WriteLine($"Even marks: {evenCount}, Odd marks: {oddCount}");

//// Reverse

//Console.WriteLine("\nMarks in reverse order:");
//for (int i = marks.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine($"Subject {i + 1}: {marks[i]}");
////}


//-------------------------- using list < string >------------------------


//List<string> studentNames = new List<string>();

//Console.WriteLine("How many student names do you want to enter?");
//string input = Console.ReadLine();

//int count;
//if (!int.TryParse(input, out count) || count <= 0)
//{
//    Console.WriteLine("Invalid number. Setting count to 1.");
//    count = 1;
//}

//for (int i = 0; i < count; i++)
//{
//    Console.Write($"Enter name {i + 1}: ");
//    string name = Console.ReadLine();
//    studentNames.Add(name);
//}

//Console.WriteLine("\n--- Student Names Entered ---");
//for (int i = 0; i < studentNames.Count; i++)
//{
//    Console.WriteLine($"Student {i + 1}: {studentNames[i]}");
//}



//using multiplication_table;

//List<int> marks = new List<int>();

//Console.WriteLine("Enter marks one by one (0–100), enter -1 to stop:");

//while (true)
//{
//    string input = Console.ReadLine();

//    if (int.TryParse(input, out int mark))
//    {
//        if (mark == -1)
//        {
//            break;
//        }
//        else if (mark < 0 || mark > 100)
//        {
//            Console.WriteLine("Invalid. Marks must be between 0 and 100.");
//        }
//        else
//        {
//            marks.Add(mark);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter digits.");
//    }
//}

//// display total
//Console.WriteLine($"\ntotal number of marks entered: {marks.Count}");

//// average
//if (marks.Count > 0)
//{
//    int sum = 0;
//    foreach (int m in marks) sum += m;
//    double average = (double)sum / marks.Count;
//    Console.WriteLine($"Average marks: {average}");
//}
//else
//{
//    Console.WriteLine("No marks entered.");
//}

//// remove failed marks 
//marks.RemoveAll(m => m < 35);


//Console.WriteLine("\nFinal marks , failed marks not included");
//foreach (int m in marks)
//{
//    Console.WriteLine(m);
//}

BASICOPT operations = new BASICOPT();
operations.multiplicationimp();
operations.vowelcount();
operations.arraystoring();
operations.stringlist();
operations.markslist();