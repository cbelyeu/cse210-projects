using System;

class Outdoor : Event {
    private string _forecast;
    
    public Outdoor(string title,string desc,DateTime date, Address address, string forecast)
        : base(title,desc,date,address) {
            _forecast = forecast;
            _eventType = "Outdoor";
    }
    
    public override string UniqueDetails() {
        return _forecast + "\n";
    }
}