using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction a = new Fraction();
        Fraction b = new Fraction(5);
        Fraction c = new Fraction(3,4);

        Console.WriteLine(a.getFractionString());
        Console.WriteLine(a.getDecimalValue());

        Console.WriteLine(b.getFractionString());
        Console.WriteLine(b.getDecimalValue());

        Console.WriteLine(c.getFractionString());
        Console.WriteLine(c.getDecimalValue());
        
        a.setBottom(3);
        Console.WriteLine(a.getFractionString());
        Console.WriteLine(a.getDecimalValue());
    }
}