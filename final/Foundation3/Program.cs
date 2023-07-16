using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string filename = "EventsCSV.txt";
        FileHandler f = new FileHandler(filename);
        List<Event> events = new List<Event>();
        events = f.ReadFile();
        CreateMessages(events, f);
    }

    static void CreateMessages(List<Event> events, FileHandler f)
    {
        int eventNum = 0;
        foreach (Event e in events)
        {
            eventNum += 1;
            Console.WriteLine($"Event Number {eventNum}");
            StandardDisplayEvents(e,f);
            FullDisplayEvents(e,f);
            ShortDisplayEvents(e,f);
        }
    }
    static void StandardDisplayEvents(Event e, FileHandler f)
    {
        Console.WriteLine($"{e.GetStandardDesc()}\n");
        f.WriteFile(e.GetStandardDesc());
    }
    
    static void FullDisplayEvents(Event e, FileHandler f)
    {
        Console.WriteLine($"{e.GetFullDesc()}\n");
        f.WriteFile(e.GetFullDesc());
    }

    static void ShortDisplayEvents(Event e, FileHandler f)
    {
        Console.WriteLine($"{e.GetShortDesc()}\n");
        f.WriteFile(e.GetShortDesc());
    }
}