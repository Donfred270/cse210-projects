using System;

class Program
{
    static void Main(string[] args)
    {
        // creation of video objects with comments
            Video video1 = new Video("Amazing Product Review", "John Doe", 300);
            video1.Comments.Add(new Comment("Alice", "Great review, I loved the product!"));
            video1.Comments.Add(new Comment("Bob", "I disagree with some points, but good overall."));
            video1.Comments.Add(new Comment("Charlie", "I have the same product, it's awesome!"));

            Video video2 = new Video("Tech Talk: Future of AI", "Jane Smith", 180);
            video2.Comments.Add(new Comment("David", "Exciting topic! AI is the future."));
            video2.Comments.Add(new Comment("Eve", "I think AI still has a long way to go."));
            video2.Comments.Add(new Comment("Frank", "Loved this discussion."));

            Video video3 = new Video("Gadget Unboxing", "Mike Johnson", 150);
            video3.Comments.Add(new Comment("Grace", "The unboxing was fun!"));
            video3.Comments.Add(new Comment("Hannah", "Cool gadget, will definitely buy it."));

            // Create a list of videos
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // display information for each video
            foreach (var video in videos)
            {
                video.DisplayVideoInfo();
                Console.WriteLine(); // add a blank line for better readability
            }
    }
}