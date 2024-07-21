using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("An easy way of opening a Bottle", "Dean", 120);
        video1.AddComment("User1", "Nice video Dean!");
        video1.AddComment("User2", "Hahahah Funny");
        videos.Add(video1);

        Video video2 = new Video("How to act smart in every thing", "Henry", 180);
        video2.AddComment("User3", "Informative video!");
        video2.AddComment("User4", "Well explained!");
        video2.AddComment("User5", "Love it!");
        videos.Add(video2);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}