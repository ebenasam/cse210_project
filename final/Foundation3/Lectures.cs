class Lectures:Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string eventType, string speaker, int capacity, string eventTitle, string description, Address address, string date, string time) :base(eventType, eventTitle, description, address, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDesc()
    {
        string description = $"Full Marketing Material\n------------------------\n{base.GetEventType()} Event\nTitle: {base.GetTitle()}\nGuest Speaker:  {_speaker}\nDescription: {base.GetDescription()}\nSeating Capacity: {_capacity}\nDate: {base.GetDate()}\nTime: {base.GetTime()}\nLocation: {base.GetAddress().GetAddress()}";
        return description;
    }
}