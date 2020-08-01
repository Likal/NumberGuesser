using System;

//Namespace
namespace NumberGuesser
{
    //Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lisa Kalych";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resets text color back to default white
            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Init correct number
            int correctNumber = 7;

            //Init guess var
            int guess = 0;

            //Ask user to guess a number
            Console.WriteLine("Guess a number between 1 and 10");

            //You want to be able to ask again if the number is incorrect by using a loop
            while(guess != correctNumber)
            {
                //Get user input
                string input = Console.ReadLine();

                //Make sure the input is an integer (number)
                if(!int.TryParse(input, out guess))

             //Match guess to correct number
                 if (guess != correctNumber)
                    {
                //Change text color
                Console.ForegroundColor = ConsoleColor.Red;

                 //Tell user it is the wrong number
                Console.WriteLine("Please enter an actual number");


                //Resets text color back to default white
                Console.ResetColor();


                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Tell user it's the right number
                Console.WriteLine("You are CORRECT!!");


                //Resets text color back to default white
                Console.ResetColor();

                //Cast to int and put in guess
                guess = Int32.Parse(input);

               

              
                }
            }

            //Output success message
            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Tell user it's the right number
            Console.WriteLine("You are CORRECT!!");


            //Resets text color back to default white
            Console.ResetColor();






        }
    }
}
