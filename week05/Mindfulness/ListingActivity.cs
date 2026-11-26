//
// Author: Geoffrey McIntyre
// Week 5 Mindfulness Project
// 
// "ListingActivity" class -- inherits from "Activity"
//

using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private static Random randomGenerator = new Random();
    public ListingActivity() : base("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following question");

        int number = randomGenerator.Next(1,4);
        Console.WriteLine($" --- {_prompts[number - 1]} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(4);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.Clear();
        int n = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            n++;
        }

        Console.WriteLine($"You listed {n} items!");

        DisplayEndingMessage();
    }
}