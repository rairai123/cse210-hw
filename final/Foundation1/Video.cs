public class Video
{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void commentInput(Comment comment)
    {
        comments.Add(comment);
    }

    public string commentAmount()
    {
        return $"\nAmount of comments: {comments.Count}";
    }

    public void displayComments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"{comment._name}: {comment._comment}\n");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, author: {_author}, duration of video: {_length} seconds");
    }

    public void CleanDisplay()
    {
        Console.WriteLine("-----------------------------------------");
    }




    

}