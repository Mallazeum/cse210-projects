using System.Runtime.CompilerServices;

public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference( string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){
        string display = _book + " " + _chapter + ":" + _verse;
        if (_endVerse != -1)
        {
            display = display + "-" + _endVerse;
        }
        return display;
    }
}