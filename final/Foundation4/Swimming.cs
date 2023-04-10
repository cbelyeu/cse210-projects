using System;

class Swimming : Activity {
    private double _laps;
    private double _milesPerLap = 50 * 0.62;
    
    public Swimming(int duration, double laps) : base(duration) {
        _activityName = "Swimming";
        _laps = laps;
    }
    
    public override double GetDistance()
    {
        //laps are 50 meters each
        //0.62 * 50 * laps yields the number of miles per lap
        return _laps * _milesPerLap;
    }

    public override double GetSpeed()
    {
        //speed is miles per hour
        //distance is in miles
        //duration / 60 yields hours
        //miles*60/duration yields mph
        return GetDistance()*60/_duration;
    }

    public override double GetPace()
    {
        //pace is minutes per mile
        //duration / distance
        return _duration/GetDistance();
    }
}