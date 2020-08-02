using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetApp function from bottom of page and display info

            GreetUser(); // Greeting and asks for users name



            while (true)
            {

                // Initialize correct number
                //int correctNumber = 7;

                // Create a new random object Initialize correct number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Initialize guess variable
                int guess = 0;

                // Sends another message to console for user to interact with, asks user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct (using a while loop)
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its an actual number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter and actual number");

                        // Keep going
                        continue;
                    }


                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }

                }

                // Output success message

                // Print error message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!");

                //Ask user if they want to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                // Check to see if it was a yes or a no
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
                    return;
                }


            }
        }

        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lisa Kalych";

            // Change output text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Writes app info in output (after dotnet run command)
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Resets output text color back to default white
            Console.ResetColor();
        }


        // Ask user name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Sends message with user input to console
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            // Tells user its the right number as output on console
            Console.WriteLine(message);

            // Change text color back to default white
            Console.ResetColor();


        }
    }
}
            

    




