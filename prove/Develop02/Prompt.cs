using System;
using System.Collections.Generic;

class Prompt
{
    public List<string> _promptList = new List<string>();
    public Prompt()
    {

    }

    public string DisplayRndPrompt()
    {
        _promptList.Add("Who was the most interesting person I interacted with today? ");
        _promptList.Add("What was the best part of my day? ");
        _promptList.Add("How did I see the hand of the Lord in life today? ");
        _promptList.Add("What was the strongest emotion I felt today? ");
        _promptList.Add("If I had one thing I could do over today, what would it be? ");
        _promptList.Add("Did I read the scriptures today? If yes, which one? ");
        Random rnd = new Random();
        int _randIndex = rnd.Next(_promptList.Count);
        string _random = _promptList[_randIndex];

        return _random;
    }
}