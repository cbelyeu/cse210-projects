using System;

class Event {
    private string _title;
    private string _desc;
    private DateTime _date;
    private Address _address;
    protected string _eventType = "Event";

    public Event(string title,string desc,DateTime date, Address address) {
        _title = title;
        _desc = desc;
        _date = date;
        _address = address;

    }

    public string StandardDetails() {
        return _title + "\n" + _desc + "\n" + _date + "\n" + _address.FullAddress();
    }
    public string FullDetails() {
        return _eventType + StandardDetails() + UniqueDetails();
    }

    public virtual string UniqueDetails() {
        return "\n";
    }

    public string ShortDescription() {
        return _eventType + "\n" + _title + "\n" + _date + "\n";
    }
}