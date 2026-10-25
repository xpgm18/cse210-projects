using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage. ");
        string percentageChar = Console.ReadLine();
        int percentage = int.Parse(percentageChar);
        string grade;
        if (percentage > 89)
        {
            grade = "A";
        }
        else if (percentage > 79)
        {
            grade = "B";
        }
        else if (percentage > 69)
        {
            grade = "C";
        }
        else if (percentage > 59)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        if (percentage > 69)
        {
            Console.WriteLine("You passed the class");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time");
        }
        Console.WriteLine($"Your grade is {grade}");
    }
}