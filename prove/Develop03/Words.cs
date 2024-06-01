using System.IO;
public class Words
{


    List<string> indWords = new List<string>();
    List<char> hideWord = new List<char>();
    Random r = new Random();

    public Words()
    {

        string fileName = "Scripture.txt";
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            
            string [] parts = line.Split(" ");
            foreach (string part in parts)
            {
                indWords.Add(part);
            }
        }

    }


    public List<string> getList()
    {
        return indWords;
    }




    public void Display()
    {
        var cont = true;
            Console.Write("Press Enter to continue or type 'quit' to end: ");
            while(cont)
            {
            string input = Console.ReadLine() ?? string.Empty;
            if(input == "quit")
            {
                cont = false;
            }
            else
            {
                HideWord();
                ShowWord();
            }
            }
            Console.Clear();
            
    }
    
    
    
    public void HideWord()
    {
        int Num = 0;
        int rnum = r.Next(0,indWords.Count);
        string randWord = indWords[rnum];
        hideWord.AddRange(randWord);
        int total = randWord.Count();
        while (Num != total)
        {
            hideWord[Num] = '_';
            Num = Num+1;
        }

    string showWord = "";
    foreach (char let in hideWord)
    {
        showWord = showWord + let;
    }

    indWords.Remove(randWord);
    indWords.Insert(rnum, showWord);


    }
    public void ShowWord()
    {
        foreach (string words in indWords)
        {
            Console.Write($"{words} ");
        }
        hideWord.Clear();
    }
}