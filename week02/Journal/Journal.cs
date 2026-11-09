//
// Week 2 Project: Journal
// Author: Geoffrey McIntyre
// 

using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry newEntry)    // Remember: "Entry" is a type, not a field! <sigh>
    {
       entries.Add(newEntry); 
    }
    public void DisplayAll()
    {
        foreach (Entry e in entries)
        {
           e.Display(); 
        }
    }
    public void LoadFromFile(string filename)
    {
        entries.Clear();        // Make sure the list is empty so the load is indeed fresh
        Console.WriteLine("Loading from file ...");
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry e = new Entry();
            string[] parts = line.Split("|");
            e._date        = parts[0];
            e._promptText  = parts[1];
            e._entryText   = parts[2];
            this.entries.Add(e);
        }
    }
    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file ...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }
}