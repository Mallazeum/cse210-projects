using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(name,square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return (int)Math.Pow(number,2 );
    }

    static void DisplayResult(string name, int sqNum)
    {
        Console.WriteLine($"{name}, the square of your number is {sqNum}");
    }
}