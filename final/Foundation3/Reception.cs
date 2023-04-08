using System;

class Reception : Event {
    private string _contactInfoRSVP;

    public Reception(string title,string desc,DateTime date, Address address, string contactInfoRSVP)
        : base(title,desc,date,address) {
            _contactInfoRSVP = contactInfoRSVP;
            _eventType = "Reception";
    }
    public override string UniqueDetails() {
        return "RSVP: " + _contactInfoRSVP + "\n";
    }
}