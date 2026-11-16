// 
// Author: Geoffrey McIntyre
// Week 3 project Scripture Memorizer
//
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    // private List<Word> _words;
    private List<Word> _words;
    // private string _passage;
    private static Random _randomGenerator = new Random();

    // Here we pick up the desired passage of scripture and create a list of word
    // objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
        // Reference reference = new Reference(userEntry);
        // if (!reference.Found)
        // {
        //     Console.WriteLine("That reference was not found.");
        // }
        // else
        // {
        //     _passage = _reference.Passage;
        //     foreach (string text in _reference.Passage.Split(' '))
        //     {
        //         _words.Add((text, false)); // default to not hidden
        //     }       
        // }
        // return $"{_reference} {_passage}";        
    }
    public void HideRandomWords(int numberToHide)
    {
        for (int n = 0; n < numberToHide; n++)
        {
            List<Word> visible = new List<Word>();
            // This is not quite clear, being shorthand: _words is a list of objects, the
            // object being the Word class, consisting of one word and the hidden flag.
            // So, for each object in the list that is not hidden, that word-object gets added
            // to the "visible" list; then we randomly pick a word from that list, thus
            // avoiding the same word being "randomly" selected again.
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                    visible.Add(word);
            }

            if (visible.Count == 0)
                return;

            // This construct is a little bit obtuse. It doesn't say Word.Hide(), does
            // it. But given that "visible" is a list of Word objects, it works out, and
            // the word object in _words is updated too.
            visible[_randomGenerator.Next(visible.Count)].Hide();
        }
    }
    public string GetDisplayText()
    {
        // return _reference.GetDisplayText();
        List<string> parts = new List<string>();
        foreach (Word word in _words)
        {
            parts.Add(word.GetDisplayText());
        }
        // This stmt combines the scripture reference (e.g. 3:5) plus the passage
        // itself, with a space between each word.
        // It might be a little bit unfortunate that all 3 classes in this project
        // all have a method of the same name: GetDisplayText
        return _reference.GetDisplayText() + " " + string.Join(" ", parts);
    }
    public bool IsCompletelyHidden()
    {
        // the lower-case "word" in the foreach stmt could just as well be called "w"
        // or "thing" or whatever. I'm not sure using "word" doesn't present
        // ambiguity, given all the word list variations going on ...
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}