using System;

class Goal {
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed = false;

    public void SetCompletion(bool completionVal) {
        _completed = completionVal;
    }
    public Goal(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual string PrintGoal() {
        string myToString = "[";
        string completionStatus = " ";
        if(_completed) {
            completionStatus = "x";
        }
        myToString += completionStatus + "] " + _name + "(" + _description + ")";
        return myToString;
    }
    public virtual string GoalToString() {
        return "1|" + _name + "|" + _description + "|" + _points + "|" + _completed;
    }

    public virtual int RecordCompletion() {
        _completed = true;
        return _points;
    }
}