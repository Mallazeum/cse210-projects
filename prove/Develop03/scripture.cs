using System.Data;
using System.Globalization;

public class Scripture{
    Random rand = new Random();
    private Reference _reference;
    List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text){
        _reference = reference;
        List<string> strList = text.Split(" ").ToList();
        foreach(string word in strList)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords (int numberToHide)
    {
        for(int i = 0; i<numberToHide; i++)
        {
            Word wordToHide;
            // If statement to break out of the loop if we have hidden the last word and are trying to hide more words 
            // so that the do while loop does not go forever
            if(IsCompletelyHidden())
            {
                break;
            }

            // Do while loop to make sure i don't hide a word that has already been hidden

            do
            {
                int rNum = rand.Next(_words.Count());
                wordToHide = _words[rNum];
            }while (wordToHide.IsHidden());
            wordToHide.Hide();
        }

    }

    public string GetDisplayText(){
        string display = _reference.GetDisplayText() + " -- ";

        foreach (Word word in _words){
            display = display + word.GetDisplayText() + " ";
        }

        return display;
    }

    public bool IsCompletelyHidden()
    {
        int cnt_hidden = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
                cnt_hidden++;
        }
        return cnt_hidden >= _words.Count();
    }
}