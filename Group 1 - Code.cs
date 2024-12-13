using System;

int givenInput;
int userGuess;
int givenInput2;
int userGuess2;
int pointA = 0;
int pointB = 0;
int chancesA = 3;  // Chances for Player 1
int chancesB = 3;  // Chances for Player 2
const int POINTS_TO_WIN = 3;  // Points needed to win

Console.WriteLine("Welcome to Loreto's Game! Choose an Option:");
Console.WriteLine("[1] Play");
Console.WriteLine("[2] Exit");
Console.Write("Option: ");

int choice = Convert.ToInt32(Console.ReadLine()); // Choice to Play or exit

Console.WriteLine(" "); // SPACE

if (choice == 1)
{
    while (choice == 1)
    {
        choice = 0;

        do
        {
            // PLAYER 2'S TURN TO GUESS
            Console.WriteLine("Player 1! Please enter a number: ");

            //////// REMOVE INPUT NUMBER SYNTAX ///////
            ConsoleKeyInfo key;
            string input = string.Empty;
            while (true)
            {
                key = Console.ReadKey(false);  // true means the key won't be displayed
                if (key.Key == ConsoleKey.Enter) break;  // Exit loop on Enter key
                if (key.Key == ConsoleKey.Backspace && input.Length > 0)  // Handle Backspace
                {
                    input = input.Substring(0, input.Length - 1);
                }
                else if (!Char.IsControl(key.KeyChar))  // Add character to input
                {
                    input += key.KeyChar;
                }
            }
            //////// /////// //////// /////// ////////

            givenInput = Convert.ToInt32(input); // PLAYER 1 ENTER NUMBER

            Console.Write("Done? [1] Yes | [2] No : "); // VERIFY IF DONE INPUTTING
            int verify = Convert.ToInt32(Console.ReadLine()); // verify input

            if (verify == 1) // Continue process after confirming
            {
                verify = 0;
                chancesB = 3; // Reset Player 2's chances
                Console.WriteLine("");

                while (chancesB > 0) // Player 2 guesses
                {
                    Console.Write("Player 2! Guess the Number (1-50): ");
                    userGuess = Convert.ToInt32(Console.ReadLine()); // Player 2 input

                    if (userGuess == givenInput)
                    {
                        Console.WriteLine($"You are correct! The Number is {givenInput}. Player 2 gained 1 Point!");
                        pointB++;
                        break; // Exit guessing loop
                    }
                    else
                    {
                        chancesB--;
                        Console.WriteLine("Incorrect! Try again!");
                        if (chancesB > 0)
                        {
                            Console.WriteLine($"You have {chancesB} chances left.");
                        }
                        else
                        {
                            Console.WriteLine("You've run out of chances!");
                        }
                    }
                }

                Console.WriteLine($"Player 1: {pointA}/{POINTS_TO_WIN} | Player 2: {pointB}/{POINTS_TO_WIN}"); // SCOREBOARD
                Console.WriteLine("");
            }

            // PLAYER 1'S TURN TO GUESS
            Console.WriteLine("Player 2! Please enter a number: "); // PLAYER 2 ENTER NUMBER

            //////// REMOVE INPUT NUMBER SYNTAX ///////
            ConsoleKeyInfo key1;
            string input1 = string.Empty;
            while (true)
            {
                key1 = Console.ReadKey(false);  // true means the key won't be displayed
                if (key1.Key == ConsoleKey.Enter) break;  // Exit loop on Enter key
                if (key1.Key == ConsoleKey.Backspace && input1.Length > 0)  // Handle Backspace
                {
                    input1 = input1.Substring(0, input1.Length - 1);
                }
                else if (!Char.IsControl(key1.KeyChar))  // Add character to input
                {
                    input1 += key1.KeyChar;
                }
            }
            //////// /////// //////// /////// ////////

            givenInput2 = Convert.ToInt32(input1);

            Console.WriteLine("Done? [1] Yes | [2] No"); // VERIFY IF DONE
            int verify2 = Convert.ToInt32(Console.ReadLine()); // VERIFY INPUT

            if (verify2 == 1)
            {
                verify2 = 0;
                chancesA = 3; // Reset Player 1's chances
                Console.WriteLine("Player 1! Guess the Number (1-50): "); // PLAYER 1 WILL GUESS

                while (chancesA > 0) // Player 1 guesses
                {
                    userGuess2 = Convert.ToInt32(Console.ReadLine()); // INPUT OF PLAYER 1

                    if (userGuess2 == givenInput2)
                    {
                        Console.WriteLine($"You are correct! The Number is {givenInput2}. Player 1 gained 1 Point!");
                        pointA++;
                        break; // Exit guessing loop
                    }
                    else
                    {
                        chancesA--;
                        Console.WriteLine("Incorrect! Try again!");
                        if (chancesA > 0)
                        {
                            Console.WriteLine($"You have {chancesA} chances left.");
                        }
                        else
                        {
                            Console.WriteLine("You've run out of chances!");
                        }
                    }
                }

                Console.WriteLine($"Player 1: {pointA}/{POINTS_TO_WIN} | Player 2: {pointB}/{POINTS_TO_WIN}"); // SCOREBOARD
                Console.WriteLine();
            }

            Console.WriteLine("Next Round? [1] Yes | [2] No"); // CONTINUE GAME?
            int continueChoice = Convert.ToInt32(Console.ReadLine());
            if (continueChoice == 2)
            {
                Console.WriteLine("THANK YOU FOR PLAYING NINJA!");
                choice = 2;
                break; // TERMINATE
            }

        } while (choice != 2);
    }
}

if (choice == 2)
{
    Console.Write("Game ends. Thank you for trying.");
}
