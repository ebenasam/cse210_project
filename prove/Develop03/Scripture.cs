public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string content, Reference reference)
    {
        List<string> stringList = content.Split(' ').ToList();
        foreach (string word in stringList)
        {
            Word newWord = new Word(word);
            _words.Add(new Word(word));
        }
        _reference = reference;
    }

public Reference getReference()    
    {
        return _reference;
    }
    public void hideWords()
    {
        Random random = new Random();
        var randomIndex =random.Next(0, _words.Count);
        while(_words[randomIndex].isHidden())
        {
            randomIndex = random.Next(0, _words.Count);
        };
    _words[randomIndex].hiddenWord();
    }
    public string getRenderedText()
    {
        string result = "";
        for (int i = 0; i < _words.Count; i++)
        {
            result = result + _words[i].showWords() + " ";
        }
    return result;
    }

    public Boolean isCompletelyHidden()
    {
        int Count = 0;
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].showWords().Substring(0, 1) == "_")
            {
                Count +=1;
            }
        }
        if (Count == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}