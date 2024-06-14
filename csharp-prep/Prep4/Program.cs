using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int input;
        do{
            Console.WriteLine("Enter Number:");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }while (input != 0);

        int total = 0;
        int largest = 0;
        foreach(int number in numbers)
        {
            total += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        int smallest = largest;
        foreach (int number in numbers)
        {
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }
        float average = total / numbers.Count;

        numbers.Sort();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}