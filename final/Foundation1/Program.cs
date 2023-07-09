using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "VideoCSV.txt";

        List<Video> v = new List<Video>();
        FileHandler f = new FileHandler(filename);
        v = f.ReadFile();

        DisplayInfo(v);
    }

    static void DisplayInfo(List<Video> videos)
    {
        Console.Clear();
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}