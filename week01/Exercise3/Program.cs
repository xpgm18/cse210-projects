using System;
//
// Geoffrey McIntyre
// CSE210 Week 1 Exercise #3: Loops
// 

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberChar = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberChar);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string guessChar = Console.ReadLine();
            guess = int.Parse(guessChar);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
        while (guess != magicNumber);
        Console.WriteLine("You guessed it!");
    }
}