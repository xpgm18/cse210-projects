using System;
using System.Collections.Generic;  
//
// Week 2 Journal Project
// Author: Geoffrey McIntyre
//
public class PromptGenerator
{
    public List<string> _prompts;   
    //"Private" means it's restricted to this class, but not really important
    //"static" means just one random object for EVERY instance of PromptGenerator
    // Otherwise, each instance would have it's own Random thing.
    private static Random randomGenerator = new Random();

    public PromptGenerator()
    {
        _prompts = new List<string>(); 
        _prompts.Add("What was the highlight of your day?");
        _prompts.Add("Who did you help today?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }
    public string GetRandomPrompt()
    {
        int number = randomGenerator.Next(1, 9);
        return _prompts[number - 1];
    }
}