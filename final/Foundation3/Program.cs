using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("100 E 200 S", "Salt Lake City", "Utah", "USA");
        LectureEvent lecture = new LectureEvent("Fireside Devotional", "Come hear the words of God in an uplifting message", "4/21/25", "7:00pm", address, "Brother Patrick", 350);
        Console.WriteLine(lecture.ShortDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();

        ReceptionEvent reception = new ReceptionEvent("Cindy and Bart", "Cpme celebrate the union of the happy couple", "7/25/22", "4:00pm", address);
        Console.WriteLine(reception.ShortDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();

        OutdoorEvent outdoor = new OutdoorEvent("Alex's Birthday", "Come celebrate Alex's Birthday", "1/1/21", "10:00am",address, "Sunnny");
        Console.WriteLine(outdoor.ShortDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine();
    }
}