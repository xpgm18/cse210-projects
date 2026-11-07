
//
// Week 2 Assignment/Project -- Journal Entries
// Author: Geoffrey McIntyre
// Extensions: 
//  1) Added 3 additional questions to the list of possible prompts
//  2) Added a catch: in case the user enters a bad file name, the pgm
//     sends a msg and allows the user to try again
//

using System;

class Program
{
    static Journal j = new Journal();
    static string filename;
    static void Main(string[] args)
    {
        string menuChoice = "1";
        Console.WriteLine("Welcome to the Journal PGM!");
        while (menuChoice != "5")
        {
            Console.WriteLine("Please select one of the following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuChoice = Console.ReadLine();
            if (menuChoice == "5")          // quit
            {
               return; 
            }
            if (menuChoice == "1")          // Create a new entry
            {
                CreateNewEntry();
            }
            if (menuChoice == "2")          // Display what's in memory
            {
                j.DisplayAll();
            }
            if (menuChoice == "3")          // Load from a file
            {
                LoadFile();
            }
            if (menuChoice == "4")          // Save to a file
            {
                SaveFile();
            }
        }
    }
    static string GetFormattedSystemDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string sysDate = theCurrentTime.ToShortDateString(); 
        return sysDate;
    }
    static void LoadFile()
    {
        if (filename == null)
        {
            Console.Write("Enter the name of your journal file: ");
            filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.WriteLine("Sorry, the file name you entered does not exist. Please try again.");
                filename = null;
                return;
            }
        }
        j.LoadFromFile(filename);
    }
    static void SaveFile()
    {
        if (filename == null)
        {
            Console.Write("Enter the name of your journal file: ");
            filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.WriteLine("Sorry, the file name you entered does not exist. Please try again.");
                filename = null;
                return;
            }
        }
        j.SaveToFile(filename);
    }
    static void CreateNewEntry()
    {
        Entry e = new Entry();      // Create an "instance" of this "Entry" object
        PromptGenerator newPrompt = new PromptGenerator(); // Create an instance
        e._promptText = newPrompt.GetRandomPrompt();

        string sysDate = GetFormattedSystemDate();
        Console.WriteLine(sysDate);

        e._date = sysDate;

        Console.Write($"{e._promptText} ");
        e._entryText = Console.ReadLine();

        j.AddEntry(e);
    }
}