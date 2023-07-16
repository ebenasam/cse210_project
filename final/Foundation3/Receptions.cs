class Receptions:Event
{
    private string _email = "";

    public Receptions(string eventType, string eventTitle, string description, Address address, string date, string time,string email) :base(eventType, eventTitle, description, address, date, time)
    {
        _email = email;
    }

    public override string GetFullDesc()
    {
        string description = $"Full Marketing Material\n------------------------\n{base.GetEventType()} Event\nTitle: {base.GetTitle()}\nDescription: {base.GetDescription()}\nRSVP Here: {_email}\nDate: {base.GetDate()}\nTime: {base.GetTime()}\nLocation: {base.GetAddress().GetAddress()}";
        return description;
    }
}