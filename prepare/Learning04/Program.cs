using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment basic = new Assignment("Johnathan", "addition");
        Console.WriteLine(basic.GetSummary());

        MathAssignment math = new MathAssignment("Johnathan", "multiplication", "7.1", "10-25");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Johnathan", "Ancient History", "The Effects of Steel Weapons on Warfare");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        
    }
}