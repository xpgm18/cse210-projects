// 
// Author: Geoffrey McIntyre
// Week 3 project Scripture Memorizer
//
// Full disclosure:
// The KJV file came from GitHub. The code to load the file and to dissect the user
// desired verse or verses came from duck.ai, with many modifications by me,
// as this code is more advanced than what we've learned so far. Ditto the Book
// of Mormon, D&C, and Pearl of Great Price JSON files.
//
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
// Used for Book of Mormon, D&C, and Pearl of Great Price JSON files.
public class ScriptureFile
{
    public List<Verse> Verses { get; set; } = new();
}
public class Verse
{
    public string Reference { get; set; } = "";
    public string Text { get; set; } = "";
}
public class Reference
{
    private string _book;
    private string _passage = "";
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private bool _found = false;
    public Reference(string userEntry)
    {
        // Load KJV verses: { "Genesis 1:1": "..." }
        string json = File.ReadAllText("verses-1769.json");
        Dictionary<string, string> verses = JsonSerializer.Deserialize<Dictionary<string, string>>(json)!;
        // Console.WriteLine("It looks like the load happened and it's complete");
        // Console.WriteLine($"Loaded {verses.Count} verses.");
        // Console.WriteLine(verses["Matthew 5:5"]);
        // Console.WriteLine($"verses[{_book} {_chapter}:{_verse} ]");

        // Add verses from the other three LDS scripture files.
        AddVersesFromFlatFile(verses, "book-of-mormon-flat.json");
        AddVersesFromFlatFile(verses, "doctrine-and-covenants-flat.json");
        AddVersesFromFlatFile(verses, "pearl-of-great-price-flat.json");

        // Split "Matthew 1:8-11" into book ("Matthew") and chapter:verses ("1:8-11").
        // LastIndexOf handles multi-word books such as "Song of Solomon" and "1 John". 
        int space = userEntry.LastIndexOf(' ');
        _book = userEntry[..space];
        string[] chapterAndVerses = userEntry[(space + 1)..].Split(':');
        _chapter = int.Parse(chapterAndVerses[0]);
        string[] range = chapterAndVerses[1].Split('-');
        _verse = int.Parse(range[0]);
        _endVerse = range.Length > 1 ? int.Parse(range[1]) : _verse;

        string passage = "";        // initialize the field 
        for (int v = _verse; v <= _endVerse; v++)
        {
            string key = $"{_book} {_chapter}:{v}";
            if (verses.TryGetValue(key, out string? text))
            {
                // Console.WriteLine($"{key}  {text.Replace("#", "").Trim()}");
                // string singleVerse = text.Replace("#", "").Trim();   
                // passage += singleVerse + " ";    
                // _found = true;
                passage += text.Replace("#", "").Trim() + " ";
            }
            else
            {
                Console.WriteLine($"{key} not found.");
                return;
            }
        }
        _passage = passage.Trim();
        _found = true;
        // Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse} {passage}");
    }

    private static void AddVersesFromFlatFile(
        Dictionary<string, string> verses,
        string filePath)
    {
        string json = File.ReadAllText(filePath);

        ScriptureFile? scriptureFile =
            JsonSerializer.Deserialize<ScriptureFile>(json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        if (scriptureFile?.Verses is null)
        {
            return;
        }

        foreach (Verse verse in scriptureFile.Verses)
        {
            if (!string.IsNullOrWhiteSpace(verse.Reference) &&
                !string.IsNullOrWhiteSpace(verse.Text))
            {
                verses[verse.Reference] = verse.Text;
            }
        }
    }

    public bool Found => _found;
    public string Passage => _passage;
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";   
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}