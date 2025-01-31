public class Comment
{
    private string _userName;
    private string _textComment;

    //METHODS
    public Comment(string userName, string comment)
    {
        _userName = userName;
        _textComment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}: {_textComment}");
    }
}