using System.Data;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CommentCount ()
    {
        return _comments.Count();
    }

    public string Display()
    {
        int count = CommentCount();
        string display = $"{_title}, {_author}, {_length} minutes, {count}";
        return display;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}