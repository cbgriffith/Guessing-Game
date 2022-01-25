using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // int secretNumber = 42;
            int secretNumber = new Random().Next(1, 100);
            int guesses = 4;
            string guessOrGuesses = "";

            Console.WriteLine("Welcome to Guessing Game!");
            
            Console.WriteLine("Choose your difficulty: easy, medium, hard, or cheatmode. ");
            string difficulty = Console.ReadLine();
            Console.WriteLine($"You chose {difficulty}.");

            if (difficulty == "easy")
            {
                guesses = 8;
            }
            else if (difficulty == "medium")
            {
                guesses = 6;
            }
            else if (difficulty == "hard")
            {
                guesses = 4;
            }
            else if (difficulty == "cheatmode")
            {
                guesses = 99;
            }

            while (guesses > 0)
            {
                if (guesses == 1)
                {
                    guessOrGuesses = "guess";
                }
                else
                {
                    guessOrGuesses = "guesses";
                }
                Console.WriteLine($"You have {guesses} {guessOrGuesses} remaining.");
                Console.Write("Guess the secret number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine($"You guessed {guess}.");
                if (guess == secretNumber)
                {
                    Console.WriteLine("YOU ARE CORRECT! GOOD JOB!");
                    break;
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine($"TOO HIGH!");
                    guesses--;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("TOO LOW!");
                    guesses--;
                }
                if (guesses == 0)
                {
                    Console.WriteLine("You ran out of guesses.  GAME OVER!");
                    Console.WriteLine($"The secret number was {secretNumber}.");
                }
            }
        }
    }
}