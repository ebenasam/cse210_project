using System;

class ListingActivity : Activity
{
    List<string> activityList = new List<string> {"Who are people that you appreciate?"
                                                  ,"What are personal strength of yours?"
                                                  ,"Who are people that you have helped this week?"
                                                  ,"When have you felt the Holy Ghost this month?"
                                                  ,"Who are some of your personal heroes?"};
    

    List<string> listingList = new List<string>();

    string description = "This activity will help you relect on the good things in your life by having you list as many thing as you can in a certain area.";

    public ListingActivity(string _activityName) : base(_activityName)
    {
        SetDescription(description);
        SetActivityList(activityList);
    }

    public void DisplayActivity()
    {
        Random random = new Random();
        int index = random.Next(activityList.Count);
        Console.WriteLine("List as many reponses you can to the following prompt");
        Console.WriteLine();
        Console.WriteLine($"------ {activityList[index]} ------");
    }

    public void setListingList(List<string> ll)
    {
        listingList = ll;
    }

    public int getListingListCount()
    {
        return listingList.Count;
    }

    public void displayTotalListingCount()
    {
        Console.WriteLine($"You listed {getListingListCount()} items.");
    }
}