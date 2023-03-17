using System;

class Breathing : Activity {
    private int _breathIn = 5;
    private int _breathOut = 6;
    public Breathing() : base() {
        _frequency[0]++;
        _frequency[3]++;
        base._activityName = "Breathing Activity";
        base._description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }
    public override void DoActivity() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while (DateTime.Now < endTime) {
            Console.Write("\nBreathe in...");
            CountDown(_breathIn);
            Console.Write("\nNow breathe out...");
            CountDown(_breathOut);
            Console.Write("\n");
        }
        Console.WriteLine("\nWell done!");
    }
}