using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity type to create (1-3) or 4 to exit:");
            Console.WriteLine("1. Cycling");
            Console.WriteLine("2. Running");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    CreateCyclingActivity();
                    break;
                case "2":
                    CreateRunningActivity();
                    break;
                case "3":
                    CreateSwimmingActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void CreateCyclingActivity()
    {
        Console.WriteLine("Enter Cycling Activity details:");
        Console.Write("Date (e.g., July 21, 2024): ");
        string date = Console.ReadLine();
        Console.Write("Duration (minutes): ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Speed (mph): ");
        double speed = double.Parse(Console.ReadLine());

        Cycling cycling = new Cycling("Cycling", date, minutes, speed);
        cycling.GetSummary();
    }

    static void CreateRunningActivity()
    {
        Console.WriteLine("Enter Running Activity details:");
        Console.Write("Date (e.g., July 21, 2024): ");
        string date = Console.ReadLine();
        Console.Write("Duration (minutes): ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Distance (miles): ");
        int distance = int.Parse(Console.ReadLine());

        Running running = new Running("Running", date, minutes, distance);
        running.GetSummary();
    }

    static void CreateSwimmingActivity()
    {
        Console.WriteLine("Enter Swimming Activity details:");
        Console.Write("Date (e.g., July 21, 2024): ");
        string date = Console.ReadLine();
        Console.Write("Duration (minutes): ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Number of laps: ");
        double numLaps = double.Parse(Console.ReadLine());

        Swimming swimming = new Swimming("Swimming", date, minutes, numLaps);
        swimming.GetSummary();
    }
}