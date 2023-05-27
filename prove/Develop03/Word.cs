public class Word
{
    private string _word;
    public Word(string word)
    {
        _word = word;
    }

    public void hiddenWord()
    {
        string newword = "";
        foreach (char c in _word)
        {
            newword += "_";
        }
        _word = newword;
    }
    public string showWords()
    {
        return _word;
    }
    public Boolean isHidden()
    {
        if (_word.Substring(0, 1) == "_")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}