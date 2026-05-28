using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Learn C# as a Beginner", "Code Academy", 420);
        video1.AddComment(new Comment("Michael", "This video helped me understand classes better."));
        video1.AddComment(new Comment("Sarah", "Great explanation for beginners."));
        video1.AddComment(new Comment("Daniel", "I liked the simple examples."));
        video1.AddComment(new Comment("Emily", "This made object-oriented programming easier to understand."));

        Video video2 = new Video("Top 5 Productivity Tips", "Better Life Channel", 310);
        video2.AddComment(new Comment("James", "I will try these tips this week."));
        video2.AddComment(new Comment("Olivia", "The second tip was very useful."));
        video2.AddComment(new Comment("Lucas", "Simple and practical advice."));

        Video video3 = new Video("Easy Dinner Recipe", "Cooking with Ana", 525);
        video3.AddComment(new Comment("Sophia", "This recipe looks delicious."));
        video3.AddComment(new Comment("Ethan", "I made this yesterday and my family loved it."));
        video3.AddComment(new Comment("Isabella", "Very clear instructions."));
        video3.AddComment(new Comment("Noah", "I like how simple the ingredients are."));

        Video video4 = new Video("Beginner Workout at Home", "Fitness Daily", 600);
        video4.AddComment(new Comment("Liam", "This workout is perfect for beginners."));
        video4.AddComment(new Comment("Emma", "I liked that no equipment was needed."));
        video4.AddComment(new Comment("Mason", "Great routine for the morning."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}