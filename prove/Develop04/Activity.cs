using System;

class Activity {
    protected string _activityName;
    protected string _description;
    protected int _time;
    protected int _shortPause = 5;
    //In _frequency, the first zero stands for the number of Breathing Activities Completed, 
    //the second for the number of Reflection Activities, and the third for the number of Listing Activities.
    //The fourth stands for total Activities created.
    protected static List<int> _frequency = new List<int>() { 0,0,0,0 };
    public Activity() {
        
    }

    public void Spinner(int seconds) {
        List<string> animationFrames = new List<string>() {"|","/","-","\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        Console.Write("\\");
        while(DateTime.Now < endTime) {
            foreach(string frame in animationFrames) {
                Console.Write("\b \b" + frame);
                Thread.Sleep(800);
            }
        }
        Console.Write("\b \b");
    }
    public void CountDown(int seconds) {
        Console.Write(" ");
        bool transitionHandler = false;
        if(seconds >= 10) {
            //We need more space, and to handle two-digit numbers:
            transitionHandler = true;
            Console.Write(" ");
        }
        for (int i = seconds; i > 0; i--) {
            if(transitionHandler && i >= 9) {
                //the number is two digits, so I need to add two backspaces and two spaces 
                //until the number is a single digit
                Console.Write("\b\b  \b\b" + i);
            } else {
                Console.Write("\b \b" + i);
            }
            
                //Console.Write("\b\b  \b\b" + i);
            
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
    }
    public void CongratulateUser() {
        Console.WriteLine("\nCongratulations! You have completed " + _time + " seconds of the " + _activityName + "!\n");
    }
    public virtual void DoActivity() {
        Console.WriteLine("Something is wrong");
    }
    public void ActivitySequence() {
        Console.Write("\nHello, and welcome to the " + _activityName + "!\n\n" + _description + "\n\nHow many seconds would you like this activity to last?: ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(_shortPause);
        DoActivity();
        Spinner(_shortPause);
        CongratulateUser();
        Spinner(_shortPause);
        Console.Clear();
    }

    public string ReportFrequency() {
        Console.Clear();
        Console.WriteLine("You've chosen to view your stats!");
        
        Console.WriteLine("\nYou have completed " + _frequency[3] + 
            " Mindfulness Activities total!\n" + _frequency[0] + 
            " of which were Breathing Activities\n" + _frequency[1] + 
            " of which were Reflection Activities\nand " + _frequency[2] + 
            " of which were Listing Activities!\n");
        Console.Write("Returning to Menu in: ");
        CountDown(10);
        Console.Clear();
        return _frequency[0] + " " + _frequency[1] + " " + _frequency[2] + " " + _frequency[3];
    }
}