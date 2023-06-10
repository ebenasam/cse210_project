using System;


class BreathingActivity : Activity
{
    List<string> activityList = new List<string> { "Breath in", "Now breath out" };
    
    string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    public BreathingActivity(string _activityName) : base(_activityName)
    {
        SetDescription(description);
        SetActivityList(activityList);
    }

    public List<string> getActivityList()
    {
        return activityList;
    }
}