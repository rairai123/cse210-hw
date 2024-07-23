using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an event type to create (1-3) or 4 to exit:");
            Console.WriteLine("1. Outdoor Event");
            Console.WriteLine("2. Lecture");
            Console.WriteLine("3. Reception");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    CreateOutdoorEvent();
                    break;
                case "2":
                    CreateLectureEvent();
                    break;
                case "3":
                    CreateReceptionEvent();
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

    static void CreateOutdoorEvent()
    {
        Console.WriteLine("Enter Outdoor Event details:");
        Console.Write("Weather: ");
        string weather = Console.ReadLine();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Date: ");
        string date = Console.ReadLine();
        Console.Write("Time: ");
        string time = Console.ReadLine();

        Outdoor outdoor = new Outdoor(weather, "Outdoor", title, desc, date, time);

        Console.WriteLine("\nEvent created:");
        outdoor.shortDesc();
        outdoor.standardDesc();
        outdoor.outDesc();
    }

    static void CreateLectureEvent()
    {
        Console.WriteLine("Enter Lecture Event details:");
        Console.Write("Speaker Name: ");
        string name = Console.ReadLine();
        Console.Write("Capacity: ");
        int capacity = int.Parse(Console.ReadLine());
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Date: ");
        string date = Console.ReadLine();
        Console.Write("Time: ");
        string time = Console.ReadLine();

        Lectures lecture = new Lectures(name, capacity, "Lecture", title, desc, date, time);

        Console.WriteLine("\nEvent created:");
        lecture.shortDesc();
        lecture.standardDesc();
        lecture.lecDesc();
    }

    static void CreateReceptionEvent()
    {
        Console.WriteLine("Enter Reception Event details:");
        Console.Write("RSVP Email: ");
        string email = Console.ReadLine();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Date: ");
        string date = Console.ReadLine();
        Console.Write("Time: ");
        string time = Console.ReadLine();

        Reception reception = new Reception(email, "Reception", title, desc, date, time);

        Console.WriteLine("\nEvent created:");
        reception.shortDesc();
        reception.standardDesc();
        reception.recDesc();
    }
}