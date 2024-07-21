using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video v1 = new Video("how to code", "Steve Jobs", 15);
        Video v2 = new Video("What is the Book of Mormon", "Church of Jesus Christ", 3);
        Video v3 = new Video("Sleep, is it really that good?", "conspiracy theorist 77", 35);
        Video v4 = new Video("This one trick could save  you $1000000", "5 minute crafts", 15);
        Random rand = new Random();

        for (int i = 0; i < rand.Next(3,6); i++ )
        {
            Comment newComment = new Comment($"Person{i}", $"solid {i}/10");
            v1.AddComment(newComment);
        }

        for (int i = 0; i < rand.Next(3,6); i++ )
        {
            Comment newComment = new Comment($"Person{i}", $"{11-i}/10 would watch again");
            v2.AddComment(newComment);
        }

        for (int i = 0; i < rand.Next(3,6); i++ )
        {
            Comment newComment = new Comment($"Person{i}", $"solid {0-i}/10, would not recomend");
            v3.AddComment(newComment);
        }

        for (int i = 0; i < rand.Next(3,6); i++ )
        {
            Comment newComment = new Comment($"Person{i}", $"{i}/10 this didn't work for me");
            v4.AddComment(newComment);
        }

        List<Video> vids = new List<Video>();
        vids.Add(v1);
        vids.Add(v2);
        vids.Add(v3);
        vids.Add(v4);

        foreach(Video vid in vids)
            Console.WriteLine(vid.Display());
    }
}