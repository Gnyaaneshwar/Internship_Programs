using System;
using System.Collections.Generic;
class Battingscorecard
{
    public static void Main()
    {
        Dictionary< string,int> scorecard = new Dictionary< string,int>();

        Console.WriteLine("\n how many players ?");
        int n = Convert .ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\n enter the player{i} name :");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("invalid. Name is empty!");
            }
            else if (int.TryParse(name, out _))
            {
                Console.WriteLine("invalid. Name do not have digits ");
            }


            Console.WriteLine($"rums scored by {name}");
            int runs;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out runs))
                {
                    if (runs >= 0) 
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Runs cannot be negative. Please enter again:");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number:");
                }
            }


            scorecard[name] = runs ;
        }

        Console.WriteLine("\n ___________BAtting scorecard________");
        Console.WriteLine("{0,-20},{1,20}", "players" , "Runs");
        Console.WriteLine(new string('-', 40));

        foreach (var player in scorecard)
        {
            Console.WriteLine("{0,-20},{1,20}", player.Key, player.Value);
        }

        // to see topscorer in batting

        string topscorer = "";
        int topruns = 0;
            foreach(var player in scorecard)
        {
            if(player.Value> topruns)
            {
                topruns = player.Value;
                topscorer = player.Key;
            }
        }
            Console.WriteLine("\n top scorer :" + topscorer +"with"+ "topruns :" + topruns);

    }







}