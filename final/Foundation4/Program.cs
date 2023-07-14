using System;

class Program
{
    static void Main(string[] args)
     {
        List<Activity> activities = new List<Activity>();

        Running r = new Running(4.6, "8/25/23", 54);
        StationaryBicycle b = new StationaryBicycle(4.43,"6/13/23",72);
        Swimming s = new Swimming(11,"7/23/23",  18);

        activities.Add(r);
        activities.Add(b);
        activities.Add(s);

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("                                       WORKOUT TRACKING                                           ");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Console.WriteLine("Date\t\tActvity\t\tTime\t\tDistance\tSpeed\t\tPace");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        foreach (Activity a in activities){
            Console.WriteLine(a.GetSummary());
        }
        Console.WriteLine();
    }
}