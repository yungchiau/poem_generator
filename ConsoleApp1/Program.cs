// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            string theMatrix, system, neo, enemy = "", save = "", unplugged ="", inside = "", fight = "";

            string[] profession = new string[4], adj = new string[2];
            // Get Input From User
            Console.WriteLine("Welcome user!");
            Console.WriteLine("Let's play a game of madlibs!");
            Console.WriteLine("Please share with me your name?");
            neo = Console.ReadLine();

            // Getting the matrix variables from user
            Console.WriteLine($"Hell0 {neo}! Are you ready? What is something you want to know more"+ 
                $" about?");
            theMatrix = Console.ReadLine();

            // Getting system variables from users
            Console.WriteLine($"Oooh! you want to know more about {theMatrix} huh?");
            Console.WriteLine($"Okay well first, tell me what you already know about {theMatrix}");
            Console.WriteLine($"What noun would you categories {theMatrix} as:");
            system = Console.ReadLine();

            // Getting enemy variables from users
            Console.WriteLine($"Give me an oppsing noun to {system}");
            enemy = Console.ReadLine();

            // Getting inside variables from users
            Console.WriteLine($"Now give me any relexing noum (present tense)");
            inside= Console.ReadLine();

            // Getting all professions from user
            Console.WriteLine($"Okay, now I need 4 professions relating to {system}");

            for (int i = 0; i< profession.Length; i++)
            {
                Console.WriteLine($"Profession (plure){i+1}/{profession.Length}");
                profession[i] = Console.ReadLine();
            }

            // Getting the save variables
            Console.WriteLine($"Give me a helo-related verb (present tense)");
            save = Console.ReadLine();

            // Getting the unplugged variables
            Console.WriteLine($"Now give me a verb that makes you think about relief (past tense)");
            unplugged= Console.ReadLine();

            // Getting the adjectives
            Console.WriteLine($"Lastly I need to dystopian adjectives");
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine($"Adjective {i + 1}/ {adj.Length}:");
                adj[i] = Console.ReadLine();

            }
            // Getting the fight variable
            Console.WriteLine($"& a verb:");
            fight = Console.ReadLine();

            // Init Story
            string madlibsStory =
            $"{theMatrix} is a {system}, {neo}.That {system} is our {enemy}." +
            $"But when you're {inside}, you look around, what do you see?" +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}." +
            $"The very minds of the people we are trying to {save}." +
            $"But until we do, these people are still a part of that {system} " +
            $"and that makes them our {enemy}." +
            $"You have to understand, most of these people " +
            $"are not ready to be {unplugged}." +
            $"And many of them are so {adj[0]}," +
            $"so hopelessly {adj[1]} on the {system}," +
            $"that they will {fight} to protect it";
            // Print Story
            Console.WriteLine( madlibsStory );
            Console.ReadKey();



        }
    }
}

