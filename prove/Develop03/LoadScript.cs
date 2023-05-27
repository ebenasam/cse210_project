public class Loadscript
{
    public List<Scripture> _scriptureList = new List<Scripture>();
    Random random = new Random();
    public void LoadToFile()
    {
        string filename = "Scripture.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
            string[] reference_string = parts[0].Split(",");
            if (reference_string.Length == 3)
            {
                Reference _reference = new Reference(reference_string[0], reference_string[1], reference_string[2]);
                string _content = parts[1];
                Scripture _scripture = new Scripture(_content, _reference);
                _scriptureList.Add(_scripture);
            }
            else
            {
                Reference _reference = new Reference(reference_string[0], reference_string[1], reference_string[2], reference_string[3]);
                string _content = parts[1];
                Scripture _scripture = new Scripture(_content, _reference);
                _scriptureList.Add(_scripture);
            }
        }
    }

    public Scripture getScripture()
    {
        var randomIndex = random.Next(0, _scriptureList.Count);
        return _scriptureList[randomIndex];
    }
}