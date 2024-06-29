public class Menu
{
    Goals goal = new Goals();
                            Base b = new Base();
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4","5","6"};
        while(response != "6")
        {
            while(options.Contains(response) == false)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
                Console.WriteLine("What do you want to do today? ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response)
            {
                case "1":
                    string res = "";
                    string[] opt = {"1","2","3","4"};
                    while(res != "4")
                    {
                        while(opt.Contains(res) == false)
                        {
                            Console.WriteLine("These are the type of Goals: ");
                            Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                            Console.WriteLine("Which type of goal would you like to create? ");
                            res = Console.ReadLine() ?? String.Empty;
                        }
                        switch(res)
                        {
                            case "1":
                            Console.WriteLine(b.NameofGoal());
                            string nameGoal = Console.ReadLine() ?? String.Empty;
                            Console.WriteLine(b.shortDesc());
                            string d = Console.ReadLine() ?? String.Empty;
                            Console.WriteLine(b.amountPoints());
                            int pnts = Convert.ToInt32(Console.ReadLine());
                            Create create = new Create(nameGoal,d,pnts);
                            goal.goalInput(create);
                            Display();
                            break;

                            case "2":
                            Console.WriteLine(b.NameofGoal());
                            string nameG = Console.ReadLine() ?? String.Empty;
                            Console.WriteLine(b.shortDesc());
                            string de = Console.ReadLine() ?? String.Empty;
                            Console.WriteLine(b.amountPoints());
                            int pnt = Convert.ToInt32(Console.ReadLine());
                            Create creat = new Create(nameG,de,pnt);
                            goal.goalInput(creat);
                            Display();
                            break;
                            case "3":
                            Console.WriteLine(b.NameofGoal());
                            string nameGal = Console.ReadLine() ?? String.Empty;
                            Console.WriteLine(b.shortDesc());
                            string dc = Console.ReadLine() ?? String.Empty;
                            Console.WriteLine(b.amountPoints());
                            int pns = Convert.ToInt32(Console.ReadLine());
                            Create creation = new Create(nameGal,dc,pns);
                            goal.goalInput(creation);
                            Display();
                            break;
                        }
                    res = "";
                    }
                    
                break;
                case "2":
                goal.Display();
                break;
                case "3":
                goal.goalSave();
                break;
                case "4":
                goal.goalFind();
                break;
                case "5":
                goal.RecordEvent();
                break;
                case "6":
                Environment.Exit(0);
                break;
            }
            response = "";
        }
    }
}