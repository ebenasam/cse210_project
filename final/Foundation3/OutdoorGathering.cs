class OutdoorGathering:Event
{
    private string _weatherForecast;

    public OutdoorGathering(string weatherForecast, string eventType, string eventTitle, string description, Address address, string date, string time) :base(eventType, eventTitle, description, address, date, time)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDesc()
    {
        string description = $"Full Marketing Material\n------------------------\n{base.GetEventType()} Event\nTitle: {base.GetTitle()}\nDescription: {base.GetDescription()}\nWeather Forecast for Event: {_weatherForecast}\nDate: {base.GetDate()}\nTime: {base.GetTime()}\nLocation: {base.GetAddress().GetAddress()}";
        return description;
    }
}