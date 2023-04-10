using System;

class Activity {
    protected string _date;
    protected int _duration;
    protected string _activityName = "Activity";

    public Activity(int duration) {
        _duration = duration;
        _date = DateTime.Today.ToString("dd MMM yyyy");
    }

    public virtual double GetDistance() {
        return 0;
    }
    public virtual double GetSpeed() {
        return 0;
    }
    public virtual double GetPace() {
        return 0;
    }
    public string GetSummary() {
        return _date + " " + _activityName + "(" + _duration + " min): Distance " + String.Format("{0:0}",GetDistance()) + " miles, Speed " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile";
    }
}