public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Duration: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
    }

    public void DisplayComments()
    {
        if (_comments.Count == 0)
        {
            Console.WriteLine("No comments yet.");
            return;
        }

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
        }
    }
}