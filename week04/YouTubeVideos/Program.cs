using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and add videos
        Video video1 = new Video("Exploring Ghanaian Culture", "Enos Mike", 600);
        video1.AddComment(new Comment("Prissy", "Great video!"));
        video1.AddComment(new Comment("Lottie", "Very informative."));
        video1.AddComment(new Comment("Charles", "Loved the visuals."));
        videos.Add(video1);

        Video video2 = new Video("Ghanaian Cuisine Masterclass", "Linda Brown", 900);
        video2.AddComment(new Comment("Danny", "Delicious recipes!"));
        video2.AddComment(new Comment("Eval", "I can't wait to try these."));
        video2.AddComment(new Comment("Floyd", "Well explained."));
        videos.Add(video2);

        Video video3 = new Video("Traveling Through Ghana", "Afua Frances", 1200);
        video3.AddComment(new Comment("Gracey", "Fantastic guide!"));
        video3.AddComment(new Comment("Jayden", "Very helpful tips."));
        video3.AddComment(new Comment("Ed", "I want to visit now."));
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
