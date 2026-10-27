using System;

//
// Geoffrey McIntyre
// CSE210 Week 1 Exercise #5: Functions
// 

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username   = PromptUserName();
        int    userNumber = PromptUserNumber();
        int    square     = SquareNumber(userNumber);

        DisplayResult(username, square);

        // Console.WriteLine($"{username}, the square of your number is {square}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumberChar = Console.ReadLine();
        int userNumber = int.Parse(userNumberChar);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }
}
