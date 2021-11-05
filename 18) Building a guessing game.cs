using System;

namespace Building_a_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "King coder";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                Console.WriteLine("Enter a guess: ");
                guess = Console.ReadLine();
                guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("");
                Console.Write("You lose!");
            }
            else
            {
                Console.WriteLine("");
                Console.Write("You win!");
            }
            Console.ReadLine();
        }
    }
}
