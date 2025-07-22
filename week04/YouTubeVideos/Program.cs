using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create list to hold all videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("Exploring Ghanaian Cuisine", "TravelGhana", 420);
        video1.AddComment(new Comment("Kwame", "This made me hungry!"));
        video1.AddComment(new Comment("Ama", "I love watching your food trips."));
        video1.AddComment(new Comment("John", "Where was the jollof rice?"));

        // Create Video 2
        Video video2 = new Video("How to Build a Treehouse", "WoodWorks", 760);
        video2.AddComment(new Comment("Sarah", "This is awesome!"));
        video2.AddComment(new Comment("Jake", "I'm building one with my kids."));
        video2.AddComment(new Comment("Anita", "Loved the design."));

        // Create Video 3
        Video video3 = new Video("Beginner Guitar Lessons", "MusicStart", 300);
        video3.AddComment(new Comment("Leo", "I just played my first chord!"));
        video3.AddComment(new Comment("Zara", "This is so helpful, thank you!"));
        video3.AddComment(new Comment("Mike", "Can you do a tutorial on strumming patterns?"));

        // Create Video 4
        Video video4 = new Video("The Science of Sleep", "BrainBoost", 540);
        video4.AddComment(new Comment("Nina", "Now I understand why I dream."));
        video4.AddComment(new Comment("Ben", "This was really insightful."));
        video4.AddComment(new Comment("Liam", "Great job explaining complex stuff simply."));

        // Add all videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
