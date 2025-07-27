using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Crear videos con comentarios
        var video1 = new Video("Unboxing Gadget X", "Tech Guru", 320);
        video1.AddComment(new Comment("Alice", "Very Usefull!"));
        video1.AddComment(new Comment("Bob", "¿Where did you buy it?"));
        video1.AddComment(new Comment("Carla", "I want this item 😍"));

        var video2 = new Video("Chicken in Green sauce", "Chef Sumito", 540);
        video2.AddComment(new Comment("Dave", "Looks tasty"));
        video2.AddComment(new Comment("Ella", "¿Have more ingridents?"));
        video2.AddComment(new Comment("Felipe", "Wanna cook it."));

        var video3 = new Video("The Heaven Awaits", "PixelMan", 660);
        video3.AddComment(new Comment("Gina", "That's a great game"));
        video3.AddComment(new Comment("Hugo", "Well composed."));
        video3.AddComment(new Comment("Iván", "Waiting the next area."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Mostrar info de cada video
        foreach (var video in videos)
        {
            Console.WriteLine($"\nTitle: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"   - {comment.Author} said: \"{comment.Text}\"");
            }
        }
    }
}