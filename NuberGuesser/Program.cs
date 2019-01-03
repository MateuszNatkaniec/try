using System;

//namespace

namespace NuberGuesser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo funcion

            GreetUser();//Ask for users name and greet

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //Create a new Random objet
                Random random = new Random();
                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure it's numer
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Math guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number,please try again");
                       
                    }
                }

                //Print success message
                //Print error message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!! You geussed it!");
                Console.ForegroundColor = ConsoleColor.Yellow;

                


                

                //Ask to play again
                Console.WriteLine("Paly Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                Console.ReadLine();
            } 
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Start app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mateusz Natkaniec";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset text color
            Console.ResetColor();
        }

        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("Whats is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play game...", inputName);
        }
        //Print collor masage
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its the wrong number

            Console.WriteLine(message);
            //Reset text color
            Console.ResetColor();
        }
    }
}

