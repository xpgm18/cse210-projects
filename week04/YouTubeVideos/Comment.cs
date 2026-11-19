//
//  Week 4 YouTube Project
//
//  Author: Geoffrey McIntyre
//
using System;
public class Comment
{
    public string CommentName {get;}
    public string CommentText {get;}
    public Comment(string commentName, string commentText)
    {
        CommentName = commentName;
        CommentText = commentText;
    }
}