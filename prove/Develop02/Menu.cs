using System.IO;
using System.Collections.Generic;
public class Menu
{
    string fileName = "";
    
    Journal journal = new Journal();
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while(response!="5")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                Console.WriteLine("What would you like to do?");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch (response)
            {
                case "1":
                    Prompt newPrompt = new Prompt();
                    string prompt = newPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string answer = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, answer);
                    journal.entryInput(newEntry);
                    break;
                case "2":
                    journal.Display();
                    
                    break;
                case "3":
                    journal.journalFind();
                    break;
                case "4":
                    journal.journalSave();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}