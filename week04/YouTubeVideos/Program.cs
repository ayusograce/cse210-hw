using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the YouTubeVideos Project.\n");
        Console.WriteLine("\n------------------------------\n");

        //VIDEO 1
        Video video1 = new Video("The Complete Web Development Roadmap", "Programming with Mosh", 915);
        Comment comment1 = new Comment("webdev1", "This was a great video!!");
        Comment comment2 = new Comment("HaileyMoore", "Super useful");
        Comment comment3 = new Comment("penguin234", "I don't know how I got here");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        //VIDEO 2
        Video video2 = new Video("How to turn on a computer", "Life Hacks", 132);
        Comment comment4 = new Comment("123jack", "HAHAHA best tutorial ever!");
        Comment comment5 = new Comment("user34567", "Great!!!!!");
        Comment comment55 = new Comment("user345", "Awesome");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment55);

        //VIDEO 3   
        Video video3 = new Video("Introduction to C#", "C# academy", 1200);
        Comment comment6 = new Comment("learner1", "Thank you for this video");
        Comment comment7 = new Comment("Julia Delgado", "I understood everything. Excellent video!");
        Comment comment8 = new Comment("penguin234", "Very interesting, although I don't know how I got here.");
        Comment comment9 = new Comment("Jhon Mars", "Great content");

        video3.AddComment(comment6);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        //LIST OF VIDEOS
        List<Video> allVideos = new List<Video>{video1, video2, video3};
        foreach (Video video in allVideos)
        {
            video.DisplayAll();
        }
    }
}