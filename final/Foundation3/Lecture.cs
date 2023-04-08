using System;

class Lecture : Event {
    private int _capacity;
    private string _speaker;

    public Lecture(string title,string desc,DateTime date, Address address, string speaker, int capacity)
        : base(title,desc,date,address) {
            _speaker = speaker;
            _capacity = capacity;
            _eventType = "Lecture";
    }

    public override string UniqueDetails() {
        return _speaker + "\n" + _capacity + "\n";
    }
}