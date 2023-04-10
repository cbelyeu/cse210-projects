using System;

class Running : Activity {
    private double _distance;
    public Running(int duration, double distance) : base(duration) {
        _activityName = "Running";
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        //distance is in miles
        //duration is in minutes
        //speed is miles per hour, thus distance over duration, times 60
        return _distance/_duration * 60;
    }

    public override double GetPace()
    {
        //minutes per mile
        return _duration/_distance;
    }
}