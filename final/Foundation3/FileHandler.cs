class FileHandler
{
    private string _filename;
    private string _outputFile = "OutPut.txt";
    private List<Event> _events = new List<Event>();
    private string _csvDelimiter = "||";
    public FileHandler(string filename)
    {
        _filename = filename;

        if (File.Exists(_outputFile))
        {
            File.WriteAllText(_outputFile, "");
        }
    }

    public List<Event> ReadFile()
    {
        using (StreamReader reader = new StreamReader(_filename))
        {
            string line;
            string[] lineList;

            while ((line = reader.ReadLine()) != null)
            {
                lineList = line.Split(_csvDelimiter);

                string eventType = lineList[0];
                string eventTitle = lineList[1];
                string eventDescription = lineList[2];
                string eventDate = lineList[3];
                string eventTime = lineList[4];
                Address eventAddress = new Address(lineList[5]);

                switch (eventType)
                {
                    case "Lectures":
                        string eventSpeaker = lineList[6];
                        int eventCapacity = int.Parse(lineList[7]);
                    
                        Lectures l = new Lectures(eventType, eventSpeaker, eventCapacity, eventTitle, eventDescription, eventAddress, eventDate, eventTime);
                        _events.Add(l);
                        break;

                    case "Receptions":
                        string email = lineList[6];
                        Receptions r = new Receptions(eventType, eventTitle, eventDescription, eventAddress, eventDate, eventTime, email);
                        _events.Add(r);
                        break;

                    case "OutdoorGathering":
                        string eventforecast = lineList[6];
                        OutdoorGathering o = new OutdoorGathering(eventforecast,eventType, eventTitle, eventDescription, eventAddress, eventDate, eventTime);
                        _events.Add(o);
                        break; 

                }
            }
        }
        return _events;
    }
    public void writeFile(string textString)
    {
        using (StreamWriter writer = new StreamWriter(_outputFile, true))
        {
            writer.WriteLine(textString);
            writer.WriteLine();
        }
    }
}