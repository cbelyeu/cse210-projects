using System;

class Eternal : Goal {
    
    public Eternal(string name, string description, int points) : base(name,description,points) {
    }
    public override string PrintGoal() {
        string myToString = "[";
        string completionStatus = " ";
        myToString += completionStatus + "] " + _name + "(" + _description + ")";
        return myToString;
    }
    public override string GoalToString() {
        return "2|" + _name + "|" + _description + "|" + _points + "|" + _completed;
    }
    public override int RecordCompletion() {
        return _points;
    }
}