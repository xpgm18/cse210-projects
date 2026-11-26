//
// Author: Geoffrey McIntyre
// Week 5 Mindfulness Project
// 
// "BreathingActivity" class -- inherits from "Activity"
//

using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity",
            "This activity will help you relax by walking you through breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();

            Console.WriteLine("Breathe in ...");
            ShowCountDown(3);

            Console.WriteLine("Breathe out ...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}