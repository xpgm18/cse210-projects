//
//  Week 4 YouTube Project
//
//  Author: Geoffrey McIntyre
//
using System;
using System.Collections.Generic;
public class Video
{
    public string Title {get;}
    public string Author {get;}
    public int LengthInSeconds {get;}
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }
    public void AddComment(string commentName, string commentText)
    {
        // The .Add(comment) has only one field because we're adding an object
        // consisting of 2 fields, rather than 2 fields
        Comment comment = new Comment(commentName, commentText); // create an object
        _comments.Add(comment);
    }
    public int GetNbrOfComments()
    {
        return _comments.Count;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{Title} by {Author}, {LengthInSeconds} seconds long");
        int n = GetNbrOfComments();
        Console.WriteLine($"There are {n} comments, displayed as follows:");
        DisplayComments();
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"   {comment.CommentName}: {comment.CommentText}");
        }
    }
}