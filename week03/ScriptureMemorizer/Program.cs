// 
// Author: Geoffrey McIntyre
// Week 3 project Scripture Memorizer

// Extensions:
//   1) A full version of the KJV bible is loaded and the user enters a valid
//      reference (no hard-coded scripture in the pgm)
//   2) Already hidden words are not "re-hidden"
//   3) The user can specify the number of words at a time to be hidden at any time
//      (the default is 1)
//
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userEntry = "";
        int numberToHide = 1;
        int workNumber;
        Console.Clear();
        Console.WriteLine("This is the ScriptureMemorizer Program. Options are as follows:");
        Console.WriteLine($"   1) Enter the number of words to hide each time (default is {numberToHide})");
        Console.WriteLine("   2) 'quit' to exit the pgm");
        Console.WriteLine("   3) Enter the KJV scripture verse or range of verses");
        Console.WriteLine("      NOTE: You MUST enter the full book name and verse(s) accurately!");
        Console.WriteLine("      e.g. Matthew 5:5 or Genesis 8:1-5 or 1 John 1:3");
        Console.WriteLine("Any deviation from the instructions causes unpredictable results.");
        // Console.WriteLine("You may alternatively also enter a number to indicate the number of words to hide at a time. Default is 1.")

        userEntry = Console.ReadLine();
        if (userEntry == "quit")
            return;
        int.TryParse(userEntry, out workNumber);
        if (workNumber > 0)         // The user entered a number (of words to hide)
        {
            numberToHide = workNumber; 
            Console.WriteLine($"{numberToHide} word(s) at a time will be hidden. Please enter a reference now:");
            userEntry = Console.ReadLine();     // This had better be a reference ...
            if (userEntry == "quit")
                return;
        }
           
        Reference reference = new Reference(userEntry); // Load the scriptures and get the desired verse(s)   
        if (!reference.Found)
            return;

        Scripture scripture = new Scripture(reference, reference.Passage);
        Console.WriteLine(scripture.GetDisplayText());
        
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide a word, or a nbr to change the nbr of words to hide at a time, or 'quit' to quit.");

        while (!scripture.IsCompletelyHidden())
        {
            userEntry = Console.ReadLine();
            if (userEntry == "quit")
                break;
            Console.Clear();
            int.TryParse(userEntry, out workNumber);
            if (workNumber > 0)         // The user entered a number (of words to hide)
            {
                numberToHide = workNumber; 
                Console.WriteLine($"{numberToHide} word(s) at a time will be hidden.");
            }

            scripture.HideRandomWords(numberToHide);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. We presume that means you've memorized the scripture! Good job!");
            }
            else
            {
                Console.WriteLine("Press Enter to hide a word, or quit.");
            }
        }
    }
}