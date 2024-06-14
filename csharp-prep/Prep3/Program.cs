using System;

class Program
{
    static void Main(string[] args)
    {
        Random randGen = new Random();
        int guess;
        string playAgain;
        
        do
        {
            int count = 0;
            int magNum = randGen.Next(1,100);
            do
            {
                Console.WriteLine("Guess a number between 1 and 100.");
                guess = int.Parse(Console.ReadLine());
                if (guess > magNum)
                {
                    Console.WriteLine("To High, guess lower");
                }
                else if (guess < magNum)
                {
                    Console.WriteLine("To Low, Guess higher");
                }
                count += 1;
            }while (guess != magNum);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {count} guesses");
            Console.WriteLine("Would you like to play again?");
            playAgain = Console.ReadLine();
        }while(playAgain == "yes");
    }
}