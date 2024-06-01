public class Scripture
{
    List<string> _words;
    Words w = new Words();
    Reference _rf;

    

    public Scripture(Reference refer, List<string> words)
    {
        
        
        _words = words;
        _rf = refer;


    }
    
    public void HideRandomWord()
    {



    }

    public void Display()
    {
        foreach (string word in _words)
        {
            Console.Write($" {word}");
            w.HideWord();
        }


    }

    public void IsVerseDone()
    {



    }

}