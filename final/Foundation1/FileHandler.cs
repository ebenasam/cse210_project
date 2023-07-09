class FileHandler
{
    private string _filename;
    private List<Video> _videoList = new List<Video>();
    private string _csvDelimiter = "||";
    public FileHandler(string filename)
    {
        _filename = filename;
    }

    public List<Video> ReadFile()
    {
        using (StreamReader reader = new StreamReader(_filename))
        {
            string line;
            string[] lineList;

            string title;
            string author;
            int length;

            while ((line = reader.ReadLine()) != null)
            {
                lineList = line.Split(_csvDelimiter);
                List<Comment> commentList = new List<Comment>();

                if (lineList.Count() > 3)
                {
                    for (int i = 3; i< lineList.Count()-1; i++)
                    {
                        string cName = lineList[i];
                        i++;
                        string cComment = lineList[i];
                        Comment comment = new Comment (cName, cComment);
                        commentList.Add(comment);
                    }
                }

                title = lineList[0];
                author = lineList[1];
                length = int.Parse(lineList[2]);
                _videoList.Add(new Video(title, author, length, commentList));
            }
        }
        return _videoList;
    }

}