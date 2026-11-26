//
// Author: Geoffrey McIntyre
// Week 5 Mindfulness Project
// 
// Main pgm:
//
// Extensions:
//   1) The reflecting questions are asked only once. In the event that the pgm
//      runs out of questions, the pgm ends the event. In other words, the activity
//      ends when either the session duration expires, or the pgm runs out of 
//      questions, whichever comes first
//
using System;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice  = "1";
        while (menuChoice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

        if (menuChoice == "4")          // quit
            return;
        
        if (menuChoice == "1")
            StartBreathingActivity();

        if (menuChoice == "2")
            StartReflectingActivity();

        if (menuChoice == "3")
            StartListingActivity();
        }

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.WriteLine(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        // List <string> animationString = new List<string>();
        // animationString.Add("|");
        // animationString.Add("/");
        // animationString.Add("-");
        // animationString.Add("\\");
        // animationString.Add("");
        // animationString.Add("|");
        // animationString.Add("/");
        // animationString.Add("-");
        // animationString.Add("\\");
        // foreach (string s in animationString)
        // {
        //     Console.WriteLine(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(5);

        // int i = 0;
        // while (DateTime.Now < endTime)
        // {
        //     string s = animationString[i];
        //     Console.WriteLine(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        //     i++;
        //     if (i >= animationString.Count)
        //         i = 0;
        // }

        // Console.WriteLine("Done");
    }
    static void StartBreathingActivity()
    {
        Activity a = new BreathingActivity();
        a.Run();
        // This activity will help you relax by walking you through breathing 
        // in and out slowly. Clear your mind and focus on your breathing.

        // How long, in seconds, would you like for your session?

        // clear screen
        // Get ready ... plus a spinner for a couple of seconds
         
        // Breathe in ... [numbers counting down, like, 4, 3, 2, 1]
        // Now breathe out ... [numbers counting down, like 4, 3, 2, 1]
        // The "breathe in, breathe out" thing will repeat until the session time
        // expires

        // Well done!!
        // Little spinner for whatever reason ...

        // You have completed another [30] seconds of the Breathing Activity.
        
    }
    static void StartReflectingActivity()
    {
        Activity b = new ReflectingActivity();
        b.Run();

        // This activity will help you reflect on times in your life when you have
        // shown strength and resilience. This will help you recognize the power you have
        // and how you can use it in other aspects of your life.

        // How long, in seconds, would you like for your session?

        // Get ready...

        // Consider the following prompt:
        // --- Think of a time when you did something really difficult
         
        // When you have something in mind, press Enter to continue.

        // Now ponder on each of the following questions as they related to this
        // experience.
        // You may begin in: 4 < a countdown of 4. Arbitrary number, I think>
        // Clear screen
        // > How did you feel when it was complete? <and a spinner for an arbitrary 
        //   number of seconds>
        // >What is your favorite thing about this experience? <and a spinner>

        // Well done!!
        // <spinner -- but why? we're done!>
         
        // You have completed another 30 seconds of the Reflecting Activity
    }
    static void StartListingActivity()
    {
        Activity c = new ListingActivity();
        c.Run();
        // This activity will help you reflect on the good things in your life by 
        // having you list as many things as you can in a certain area.
        // The user can then actually type in responses until the given duration
        // You listed 4 items! <for example>

        // Well done!!
        // spinner
        // You have completed another 20 seconds of the ListingActivity
    }

}