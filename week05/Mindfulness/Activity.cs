//
// Author: Geoffrey McIntyre
// Week 5 Mindfulness Project
// 
// "Activity" class -- is an "abstract" class
//

using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private List<string> animationStrings = new List<string>();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
    }
    public abstract void Run();
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready ...");
        ShowSpinner(4);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 9)
                Console.Write("\b \b\b \b");
            else
                Console.Write("\b \b");
        }
    }
}