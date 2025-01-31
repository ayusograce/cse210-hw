
public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public void AddComment(Comment comment)
    {
        //ADDS A COMMENT TO THE LIST OF COMMENTS
        _comments.Add(comment);
    }
    public int NumberOfComments()
    {
        //COUNTS THE LENGTH OF THE LIST
        int number = _comments.Count;
        return number;
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_lenght} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("\nComments:");

        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("\n------------------------------\n");

    }
}