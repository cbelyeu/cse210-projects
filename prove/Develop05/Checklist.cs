using System;

class Checklist : Goal {

    int _repetitions;
    int _finishedRepetitions = 0;
    int _bonus;
    public Checklist(string name, string description, int points, int repetitions, int bonus) : base(name,description,points) {
        _repetitions = repetitions;
        _bonus = bonus;
    }
    public override string PrintGoal() {
        string myToString = base.PrintGoal() + " -- Currently completed: " + _finishedRepetitions + 
            "/" + _repetitions;
        return myToString;
    }

    public override string GoalToString() {
        return "3|" + _name + "|" + _description + "|" + _points + "|" + _completed + "|" + _repetitions 
            + "|" + _finishedRepetitions + "|" + _bonus;
    }

    public override int RecordCompletion() {
        int pointsEarned = _points;
        _finishedRepetitions += 1;
        if(_finishedRepetitions == _repetitions) {
            _completed = true;
            pointsEarned += _bonus;
        }
        return pointsEarned;
    }

    public void SetFinishedRepetitions(int finishRep) {
        _finishedRepetitions = finishRep;
    }
}