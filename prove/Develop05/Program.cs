using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Menu instance
        Menu menu = new Menu();

        // Display welcome message and program info
        DisplayWelcomeMessage();

        // Start the main menu loop
        menu.Display();

        // Display goodbye message
        DisplayGoodbyeMessage();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("This program helps you track and achieve your goals.");
        Console.WriteLine();
        Console.WriteLine("*** Unique Features ***");
        Console.WriteLine("1. Goal Streaks: Earn bonus points for consistently completing goals.");
        Console.WriteLine("2. Random Inspirational Quotes: Get motivated with a quote each time you complete a goal.");
        Console.WriteLine("3. Goal Categories: Organize your goals into different life areas.");
        Console.WriteLine("4. Progress Visualization: See your goal progress with ASCII art graphs.");
        Console.WriteLine("5. Time-based Goals: Set deadlines for your goals and earn time bonuses.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void DisplayGoodbyeMessage()
    {
        Console.WriteLine("Thank you for using the Eternal Quest Program!");
        Console.WriteLine("Remember: Every step forward is progress. Keep striving for your goals!");
    }
}

/* 
EXCEEDING REQUIREMENTS AND CREATIVITY

This program goes beyond the core requirements in several ways:

1. Goal Streaks:
   - The program tracks consecutive completions of goals.
   - Users earn bonus points for maintaining streaks, encouraging consistent behavior.

2. Inspirational Quotes:
   - Each time a goal is completed, the program displays a random inspirational quote.
   - This feature aims to keep users motivated and engaged.

3. Goal Categories:
   - Goals can be organized into categories (e.g., Health, Career, Personal Development).
   - This allows for better organization and the ability to focus on specific life areas.

4. Progress Visualization:
   - The program includes ASCII art graphs to visually represent goal progress.
   - This provides a quick, visual way for users to see their advancement.

5. Time-based Goals:
   - Users can set deadlines for their goals.
   - Completing goals before the deadline results in time bonus points.

6. Enhanced User Experience:
   - Added welcome and goodbye messages to make the program more engaging.
   - Included a brief explanation of unique features when the program starts.

These additions make the goal-tracking experience more comprehensive, engaging, and 
visually appealing, while also providing extra motivation for users to achieve their goals.
*/