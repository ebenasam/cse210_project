using System;


class Activity
{

    private string activityName = string.Empty;
    private List<string> activityList;
    private string description = string.Empty;


    public Activity(string _activityName)
    {
        activityName = _activityName;
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public void SetActivityList(List<string> _activityList)
    {
        activityList = _activityList.ToList();
    }

    public int DisplayMenu()
    {
        ClearConsole();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1.- Start breathing activity");
        Console.WriteLine("   2.- Start reflection activity");
        Console.WriteLine("   3.- Start listing activity");
        Console.WriteLine("   4.- Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }

    public int DisplayWelcomeMessage()
    {
        ClearConsole();
        Console.WriteLine($"Welcome to the {char.ToUpper(activityName[0])}{activityName.Substring(1)} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int seconds = int.Parse(Console.ReadLine());

        return seconds;
    }

    public void DisplayGetReady()
    {
        ClearConsole();
        Console.WriteLine("Get ready...");
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

    public void FinishActivity(int numSecondsToRun, string _activityName)
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed another {numSecondsToRun} seconds of the {_activityName} Activity.");

    }

    public string getActivityName()
    {
        return activityName;
    }
}