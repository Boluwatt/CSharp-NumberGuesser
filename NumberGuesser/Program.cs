using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GetUserInfo();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 15);
                int guess = 0;

                Console.WriteLine("Guess a Number between 1 and 15");

                while (correctNumber != guess)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Your Guess is Wrong... Please Try Again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You Guessed Right!!!");

                while (true)
                {
                    Console.WriteLine("Play Again? [Y or N]");
               
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response");
                    }
                }
            }
        }

        static void GetAppInfo() 
        {
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Boluwatife Oluwagbamila";
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GetUserInfo()
        {
            Console.WriteLine("What is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", input);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = (color);

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
