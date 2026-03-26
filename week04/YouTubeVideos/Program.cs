using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video
        {
            Title = "Learn C# in 10 Minutes",
            Author = "CodeMaster",
            Length = 600
        };

        Video video2 = new Video
        {
            Title = "Gaming Highlights",
            Author = "ProGamer",
            Length = 900
        };

        Video video3 = new Video
        {
            Title = "Cooking Pasta",
            Author = "ChefLife",
            Length = 300
        };

        // Add comments to video1 :)
        video1.Comments.Add(new Comment("Luis", "Great video!"));
        video1.Comments.Add(new Comment("Ana", "Very helpful"));
        video1.Comments.Add(new Comment("John", "Nice explanation"));

        // Add comments to video2
        video2.Comments.Add(new Comment("Mike", "Awesome gameplay"));
        video2.Comments.Add(new Comment("Sara", "So cool!"));
        video2.Comments.Add(new Comment("Alex", "Loved it"));

        // Add comments to video3
        video3.Comments.Add(new Comment("Maria", "Looks delicious"));
        video3.Comments.Add(new Comment("Pedro", "I will try this"));
        video3.Comments.Add(new Comment("Laura", "Amazing recipe"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine("----------------------");
        }
    }
}