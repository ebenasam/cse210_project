public abstract class Rewards
{

    private  int _rewardsEarned = -1;
    private int _goalsCounter = 0;
    private int _rewardTrigger = 5;
    private Dictionary<int, string> _rewards = new Dictionary<int, string>();

    public Rewards(int rewardTrigger)
    {
        BuildRewards();
        _rewardTrigger = rewardTrigger;
    }

    public string TrackReward()
    {
        _goalsCounter++;
        if (_rewardsEarned + 1 == _rewards.Count())
        {
            return "";
        }

        else if (_goalsCounter == _rewardTrigger)
        {
            _goalsCounter = 0;
            _rewardsEarned++;
            return _rewards[_rewardsEarned];
        }
        else
        {
            return "";
        }
    }

    public abstract void BuildRewards();
    
    public void AddRewardItem(int i, string rewardItem)
    {
        _rewards.Add(i,rewardItem);
    }

    public List<string> GetRewards()
    {
        List<string> rewardsEarnedList = new List<string>(){""};
        if (_rewardsEarned!=-1)
        {
            for (int i = 0; i<=_rewardsEarned; i++)
            {
                rewardsEarnedList.Add(_rewards[i]);        
            }
        }
        return rewardsEarnedList;
    }

    public int GetGoalsCounter()
    {
        return _goalsCounter;
    }

    public void SetRewardsEarned(int rewardsEarned)
    {
        _rewardsEarned = rewardsEarned;
    }

    public void SetGoalsCounter(int goalsCounter)
    {
        _goalsCounter = goalsCounter;
    }

}