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
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response)
            {
                case "1":
                    Breathing b = new Breathing("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Remember to relax and focus on your breathing.","Well Done!!!");
                    Console.Clear();
                    Console.WriteLine(b.WelcomeDisplay());
                    Console.WriteLine(b.Description());
                    b.Question();
                    b.GetReady();
                    b.Animation();
                    b.Exercise();
                    Console.WriteLine(b.endMessage());
                    b.Animation();
                    break;
                case "2":
                    Reflect r = new Reflect("Reflect","This activity will help you reflect on moments in your life where you've demonstrated strength and resilience. By doing so, you'll recognize your own power and understand how to apply it to other areas of your life\n","Well Done !!!");
                    Console.Clear();
                    Console.WriteLine(r.WelcomeDisplay());
                    Console.WriteLine(r.Description());
                    r.Question();
                    r.GetReady();
                    r.Animation();
                    r.GetRandomPrompt1();
                    r.Ponder();
                    r.GetRandomPrompt2();
                    r.Animation();
                    r.GetRandomPrompt2();
                    r.Animation();
                    Console.WriteLine();
                    Console.WriteLine(r.endMessage());
                    r.Animation();
                    Console.WriteLine();
                    r.Complete();
                    r.Animation();
                    break;
                case "3":
                    Listing l = new Listing("Listing","This activity is designed to help you reflect on the positive aspects of your life by encouraging you to list as many things as you can within a specific category.\n","Well Done!!!");
                    Console.Clear();
                    Console.WriteLine(l.WelcomeDisplay());
                    Console.WriteLine(l.Description());
                    l.Question();
                    l.GetReady();
                    l.Animation();
                    l.RandomPrompt();
                    l.Countdown();
                    l.Begin();
                    Console.WriteLine(l.endMessage());
                    l.Animation();               
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }

    }

}