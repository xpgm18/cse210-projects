//
//  Week 4: YouTube videos
//
//  Author: Geoffrey McIntyre
//

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create the first of 3 videos
        Video video1 = new Video("No Deposit, No Return", "Disney", 5760);
        video1.AddComment("Ivan Ivanovitch", "American capitalist decadent filth.");
        video1.AddComment("Eumenidas Papagaikos", "Good for laughs");
        video1.AddComment("David Kohler", "Top shelf movie, possibly the best car chase footage ever!");

        // Create the second of 3 videos
        Video video2 = new Video("No More Secrets", "NewLine", 5920);
        video2.AddComment("Matthew Hinky", "Robert Redford possibly at his best.");
        video2.AddComment("Alice Pumpergoodie", "A perfect mix of humor, suspense, and drama.");
        video2.AddComment("Benjamin Doogooder", "I want that device! Where can I get one?");

        // Create the third of 3 videos
        Video video3 = new Video("Psych Season 1", "USA Network", 57960);
        video3.AddComment("Betty Boop", "Shawn is as funny and entertaining as he is annoying.");
        video3.AddComment("Candy Owens", "Gus the sidekick's facial expressions are priceless and add to the script.");
        video3.AddComment("Alexia Hoosthis", "Adorable, feel-good ");

        List<Video> v = new List<Video>();

        v.Add(video1);
        v.Add(video2);
        v.Add(video3);

        // Print out the video collection, complete with comments
        Console.Clear();
        DisplayAllVideos(v);
         
        static void DisplayAllVideos(List<Video> videos)
        {
            foreach (Video v in videos)
            {
                v.DisplayVideo();
            }          
        }
    }
}