public class Menu
{
    private VideoManager _videoManager;

    public Menu(VideoManager videoManager)
    {
        _videoManager = videoManager;
    }

    public void Display()
    {
        while (true)
        {
            Console.WriteLine("Welcome to YouTube");
            Console.WriteLine("1. Add a new video");
            Console.WriteLine("2. View videos");
            Console.WriteLine("3. Add a comment to a video");
            Console.WriteLine("4. Quit");
            Console.Write("Please select an option: ");

            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    AddNewVideo();
                    break;
                case "2":
                    ViewVideos();
                    break;
                case "3":
                    AddComment();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using YouTube. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void AddNewVideo()
    {
        Console.Write("Enter video title: ");
        string title = Console.ReadLine();
        Console.Write("Enter video author: ");
        string author = Console.ReadLine();
        Console.Write("Enter video length (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int length))
        {
            _videoManager.AddVideo(new Video(title, author, length));
            Console.WriteLine("Video added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid length. Video not added.");
        }
    }

    private void ViewVideos()
    {
        var videos = _videoManager.GetVideos();
        if (videos.Count == 0)
        {
            Console.WriteLine("No videos available.");
            return;
        }

        for (int i = 0; i < videos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {videos[i].GetTitle()}");
        }

        Console.Write("Select a video to view details (or 0 to go back): ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= videos.Count)
        {
            videos[choice - 1].Display();
            videos[choice - 1].DisplayComments();
        }
    }

    private void AddComment()
    {
        var videos = _videoManager.GetVideos();
        if (videos.Count == 0)
        {
            Console.WriteLine("No videos available to comment on.");
            return;
        }

        for (int i = 0; i < videos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {videos[i].GetTitle()}");
        }

        Console.Write("Select a video to add a comment (or 0 to go back): ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= videos.Count)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your comment: ");
            string commentText = Console.ReadLine();

            Comment comment = new Comment(name, commentText);
            videos[choice - 1].AddComment(comment);
            Console.WriteLine("Comment added successfully!");
        }
    }
}