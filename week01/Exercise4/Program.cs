using System;
using System.Collections.Generic;
//
// Geoffrey McIntyre
// CSE210 Week 1 Exercise #4: Lists
// 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int total = 0;
        int max   = 0;
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter Number: ");
            string numberChar = Console.ReadLine();
            number            = int.Parse(numberChar);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        foreach (int n in numbers)
        {
            total = total + n;
            if (n > max)
            {
                max = n;
            }
        }
        int listCount = numbers.Count;
        double average   = (double)total / listCount;
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}