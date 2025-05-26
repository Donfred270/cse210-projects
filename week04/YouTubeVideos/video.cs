using System;
using System.Collections.Generic;

public class Video
{
    // Attributs
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }  // en secondes
    public List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // method to get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display video information
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}
