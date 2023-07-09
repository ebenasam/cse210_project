class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();
    private int _commentCount;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
        _commentCount = _comments.Count();
    }

    public void DisplayVideoInfo()
    {
        string line;
        Console.WriteLine("--------------------------------------------------------------------------------");
        line = $"Title: {_title}\nAuthor: {_author}\nLenght of video: {_length} min.\nNumber of comments: {_commentCount}\n\n------COMMENTS------\n";

        if (_commentCount != 0)
        {
            for (int i = 0; i<(_commentCount); i++)
            {
                line += $"{_comments[i].GetComment()}\n";
            }
        }
        Console.WriteLine($"{line}");
    }
}