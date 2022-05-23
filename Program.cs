using System;
using System.Collections.Generic;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int secretNum= r.Next(1,100);
            int difficultyCount = 0;

            Console.WriteLine("Welcome to my number puzzle.");
            Console.WriteLine("Select your difficulty.");
            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            Console.WriteLine("4) Cheater");
            string difficultyInput = Console.ReadLine();
            int difficultySelector = int.Parse(difficultyInput);
            
            if (difficultySelector == 1){
                Console.WriteLine("Of course you would choose Easy. How mundane.");
                difficultyCount = 7;
            }
            else if (difficultySelector == 2){
                Console.WriteLine("Medium? pretty boring, eh.");
                difficultyCount = 5;
            }
            else if (difficultySelector == 3){
                Console.WriteLine("You chose hard? hmmm. you must like pain.");
                difficultyCount = 3;
            }
            else if (difficultySelector == 4){
                Console.WriteLine("I knew you would cheat.");
                difficultyCount = -1;
            }

            Console.WriteLine("Can you guess the secret number?");
            string input = Console.ReadLine();
            int parsedInput = int.Parse(input);
            int count = 0;

            Console.WriteLine(secretNum);
            
            while(count != difficultyCount)
            {
            
            if (parsedInput == secretNum)
            {
                Console.WriteLine($"You solved my number puzzle! The secret number was {secretNum}");
                count = difficultyCount;            
            }
            else 
            {
                Console.WriteLine("HaHa You Lose!!!");
                if(parsedInput > secretNum){
                    Console.WriteLine("My secret number is lower than your guess.");
                }
                else if(parsedInput < secretNum){
                    Console.WriteLine("My secret number is higher than your guess.");
                }
                Console.WriteLine("Try again to guess my secret number?");
                input = Console.ReadLine();
                parsedInput = int.Parse(input);
                count++;
            }
            if (count == difficultyCount && secretNum != parsedInput)
            {
                Console.WriteLine($"You failed my number puzzle. The secret number was {secretNum}");
            }
            }
        }
    }
}
