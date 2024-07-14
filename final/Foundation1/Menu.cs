public class Menu
{
    
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4"};
        while(response != "4")
        {
            while(options.Contains(response) == false)
            {
                Console.WriteLine("Welcome to YouTube");
                Console.WriteLine("Please select a YouTube video!");
                Console.WriteLine("1. Basic first aid \n2. Summer Outfit \n3. Ballet Dancing\n4. Quit");
                response = Console.ReadLine();
            }
            switch(response)
            {
                case "1":
                Video video1 = new Video("Basic first aid","Hans Todd ",120);
                Comment comment1 = new Comment("Justin Marion","Learning basic first aid has given me the confidence to handle emergencies more effectively.");
                Comment comment2 = new Comment("Lisa Mona","I've always wanted to learn first aid, and after watching this video, I feel much more prepared. Thank you!");
                Comment comment3 = new Comment("Apple Milder","I'm not a medical professional, but I found this video on basic first aid very informative.");
                video1.commentInput(comment1);
                video1.commentInput(comment2);
                video1.commentInput(comment3);
                video1.Display();                
                video1.CleanDisplay();
                Console.WriteLine(video1.commentAmount());
                Console.WriteLine();
                video1.displayComments();
                video1.CleanDisplay();
                break;
                case "2":
                Video video2 = new Video("Summer Outfit","The Rizz",240);
                Comment comment1a = new Comment("Emily Carter", "This video on summer outfits has really inspired my wardrobe choices for the season!");
                Comment comment2a = new Comment("Noah Smith", "I always struggle with what to wear during summer, but this video made it so much easier. Very Good!");
                Comment comment3a = new Comment("Olivia Davis", "Even though I don't follow fashion trends closely, I found this summer outfit guide really helpful.");
                video2.commentInput(comment1a);
                video2.commentInput(comment2a);
                video2.commentInput(comment3a);
                video2.Display();                
                video2.CleanDisplay();
                Console.WriteLine(video2.commentAmount());
                Console.WriteLine();
                video2.displayComments();
                video2.CleanDisplay();
                break;
                case "3":
                Video video3 = new Video("Ballet Dancing","Instructor Jessie",420);
                Comment comment1b = new Comment("Sophia Martinez", "This video on ballet dancing has truly reignited my passion for dance. It's so inspiring!");
                Comment comment2b = new Comment("James Lee", "I've always been curious about ballet, and after watching this video, I have a much greater appreciation for it.");
                Comment comment3b = new Comment("Ella Kim", "I'm not a dancer myself, but I found this video on ballet dancing incredibly fascinating and informative.");
                video3.commentInput(comment1b);
                video3.commentInput(comment2b);
                video3.commentInput(comment3b);
                video3.Display();                
                video3.CleanDisplay();
                Console.WriteLine(video3.commentAmount());
                Console.WriteLine();
                video3.displayComments();
                video3.CleanDisplay();
                break;
                case "4":
                Environment.Exit(0);
                break;
            }
            response = "";
        }
    }
}