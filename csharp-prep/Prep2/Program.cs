using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage??");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        int lastDigit = grade % 10;
        string sign = "";

        if (grade < 95 && grade >= 60)
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }

            else if (lastDigit <= 3)
            {
                sign = "-";
            }

            else 
            {
                sign = "";
            }
        }

        Console.WriteLine($"You got a: {letterGrade}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed! Well done!");
        }

        else
        {
            Console.WriteLine("You failed. Try harder next time!");
        }
    }
}