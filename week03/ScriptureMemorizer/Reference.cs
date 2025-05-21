using System;
using System.Collections.Generic;
namespace ScriptureMemorizer;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // Constructor with only book, chapter, and verseStart
    public Reference(string book, int chapter, int verseStart, int verseEnd = 0)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
        // method to get the book reference
    public string GetReference()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}