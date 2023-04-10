using System;

class Cycling : Activity {
    private double _speed;
    public Cycling(int duration, double speed) : base(duration) {
        _activityName = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        //speed is miles per hour
        //duration is minutes
        //miles = miles/hour * minutes / 60
        return _speed * _duration / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        //pace is minutes per mile
        //speed is miles per hour
        return 60/_speed;
    }
    
}