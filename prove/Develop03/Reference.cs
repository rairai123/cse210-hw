public class Reference
{

    string _book = "";
    int _startVerse;
    int _endVerse;
    int _chapter;


    public Reference(string book, int chapter, int sverse, int lverse = 0)
    {
        _book = book;
        _startVerse = sverse;
        _endVerse = lverse;
        _chapter = chapter;
    }

    public string Display()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";

    }

}