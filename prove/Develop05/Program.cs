using System; 
class Program
{
    static void Main(string[] args)
    {
        List<Rewards> rewardsList = new List<Rewards>()
        {
            new SimpleRewards(5),
            new EternalRewards (5),
            new ChecklistRewards(5)
        };
        

        bool isNew = true;
        List<Goal> goalsList = new List<Goal>();
        int totalPoints = 0;
        string goalFilename = "goals.txt";
        string rewardsFilename = "rewards.txt";

        MainMenu MainMenu = new MainMenu();
        Console.Clear();
        Console.WriteLine($"You have {totalPoints} points.\n");
        int userMainEntry = MainMenu.DisplayMenu();

        while (userMainEntry != 7)
        {
            switch (userMainEntry)
            {
                case 1:
                    GoalMenu GoalsMenu = new GoalMenu ();
                    Console.Clear();
                    int userSubEntry = GoalsMenu.DisplayMenu();
                    switch (userSubEntry)
                    {
                        case 1:
                            SimpleGoal s = new SimpleGoal(isNew);
                            goalsList.Add(s);
                            break;

                        case 2:
                            EternalGoal e = new EternalGoal(isNew);
                            goalsList.Add(e);
                            break;

                        case 3: 
                            ChecklistGoal c = new ChecklistGoal(isNew);
                            goalsList.Add(c);
                            break;
                    }
                    break;

                case 2:
                    if (goalsList.Count !=0)
                    {
                        DisplayFullGoals(goalsList);                        
                    }
                    else
                    {
                        DisplayNoGoalsMsg();
                    }
                    break;

                case 3:
                    if (goalsList.Count !=0){
                        DisplayRewards(rewardsList);
                    }
                    else
                    {
                        DisplayNoGoalsMsg();
                    }
                    break;

                case 4:
                    if (goalsList.Count !=0)
                    {
                        FileHandler fWrite = new FileHandler(goalFilename, rewardsFilename,rewardsList, goalsList, totalPoints);
                        fWrite.WriteGoals();
                        fWrite.WriteRewards();
                    }
                    else
                    {
                        DisplayNoGoalsMsg();
                    }
                    break;

                case 5:
                    FileHandler fRead = new FileHandler(goalFilename, rewardsFilename,rewardsList, goalsList, totalPoints);
                    goalsList.Clear();
                    goalsList = fRead.ReadGoals();
                    totalPoints = fRead.GetTotalPoints();
                    rewardsList.Clear();
                    rewardsList=fRead.ReadRewards();
                    break;

                case 6:
                   
                    if (goalsList.Count != 0)
                    {
                        DisplayGoals(goalsList);
                        Console.Write("Which goal did you accomplish? ");
                        userSubEntry = int.Parse(Console.ReadLine()) -1;
                        totalPoints += RecordGoal(userSubEntry, goalsList, totalPoints);
                    }
                    else
                    {
                        DisplayNoGoalsMsg();
                    }
                    break;
            }
            Console.Clear();
            Console.WriteLine($"You have {totalPoints} points.\n");
            userMainEntry = MainMenu.DisplayMenu();
        }

        static void DisplayRewards(List<Rewards> rewardsList)
        {
            Console.Clear();
            foreach(Rewards r in rewardsList)
            {
                string line = ($"{r.GetType().Name}:\n    ");
                List<string> rewardsString = new List<string>(r.GetRewards());

                for(int i = 1; i<rewardsString.Count(); i++)
                {
                    line += $"{rewardsString[i]}, ";
                }
                Console.WriteLine(line);
            }
            Console.WriteLine("\nPress Enter to Continue: ");
            Console.ReadLine();
        }

        static void DisplayFullGoals(List<Goal> goalsList)
        {
            Console.Clear();
            int i = 1;

            foreach(Goal g in goalsList)
            {
                Console.WriteLine($"{i}.  [{g.GetCheckBox()}] {g.GetGoal()} ({g.GetDescription()}){g.GetXofYSummary()}");
                i++;
            }
            Console.Write("Press Enter to return to Main Menu:  ");
            Console.ReadLine();
        }

        static void DisplayGoals(List<Goal> goalsList)
        {
            Console.Clear();
            int i = 1;
            foreach(Goal g in goalsList)
            {
                Console.WriteLine($"{i}.  [{g.GetCheckBox()}] {g.GetGoal()}");
                i++;
            }
        }

        int RecordGoal(int entry, List<Goal> goalsList, int totalPoints)
        {
            int pointsEarned = 0;
            
            if (entry >=0 && entry < goalsList.Count)
            {
                goalsList[entry].RecordEvent();
                pointsEarned = goalsList[entry].GetPoints();
                Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points.");
                Console.WriteLine($"You now have {pointsEarned + totalPoints} points.\n");
                
                RecordReward(goalsList[entry].GetType().Name);

                Console.WriteLine("Press Enter to return to Main Menu:  ");
                Console.ReadLine();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Not a valid entry.");
                Console.ReadLine();
            }
            return pointsEarned;
        }

        void RecordReward(string goal)
        {
            string reward = "";
            foreach(Rewards r in rewardsList){
                if (r.GetType().Name.Contains(goal.Substring(0,5)))
                {
                    reward = r.TrackReward();
                }
            }

            if (!string.IsNullOrEmpty(reward))
            {
                Console.WriteLine($"\n\nCongratulations!  You've earned {goal}: {reward}.  Keep Up the Good work!\n\n");
            }
        }

        static void DisplayNoGoalsMsg()
        {
            Console.Clear();
            Console.WriteLine("You don't have any recorded goals yet.  \nPress Enter to return to Main Menu, then create a goal first.");
            Console.ReadLine();
        }
    }
}