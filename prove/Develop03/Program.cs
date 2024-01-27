using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public HideRandomWords(numberToHide: int):void
    {
        
    }

    GetDisplayText() : string
    {
        return $"{_reference.GetDisplayText()} {_words.GetDisplayText()}";
    }

    IsCompletelyHidden() : bool
    {

    }

}


public class Word 
{
    


}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Method to get display text
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}


class Program
{
    static void Main()
    {
        // Instantiate a Reference object
        Reference reference = new Reference("2 Nephi", 2, 11, 15);

        // Display the result of GetDisplayText
        Console.WriteLine(reference.GetDisplayText());
    }
}