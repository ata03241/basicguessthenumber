using System;

namespace guessgame {
    class Program {
        static void Main(string[] args) {
         guessnumber();
        }

        private static void guessnumber() {

            Console.WriteLine("Welcome to the Guess the Number Game!");
            bool userN = false;
            while(true)
            {
                System.Console.WriteLine("Enter your name: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                System.Console.WriteLine($"Hello {input}");  
                break;  
                } else {
                    System.Console.WriteLine("Whatt");
                    continue;
                }
            }

            int maxattempts = 10;
            int bestscore = int.MaxValue;
            bool playagain = false;

            while(!playagain) {
                Random rnd = new Random();
                int ans = rnd.Next(1, 100);

                Console.WriteLine("Guess game you the to guess the number between 1-100");

                for (int i = 1; i <= maxattempts;) {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Attempt " + i + ":Enter your guess: ");
                string chance = Console.ReadLine();
                int remaining = maxattempts - i;
                int guess;

                if (int.TryParse(chance, out guess)) {                   
                   if (guess == ans) {
                    if (i < bestscore) {
                        bestscore = i; 
                    }  
                    Console.ForegroundColor = ConsoleColor.Yellow;                  
                    Console.WriteLine("Congratulation! you guessed in " + i + " times");
                    Console.WriteLine("Your best score is " + bestscore + " attempts.");
                    break;
                   }
                   else if (guess < ans) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too low! Try again you still have " + remaining + " times left");
                   }                   
                   else if(guess > ans) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("To high try again you still have " + remaining + " times left");
                   }
                   i++;
                } 
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid numbber. Please enter a valid number between 1-100: ");
                }
            }            
            Console.WriteLine("game over");

            Console.WriteLine("Do you want to play again (y/n)");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer != "y") {
                playagain = false;
                Console.WriteLine("Thanks for playing ");
                break;
            }
        }
            
        }
    }
}