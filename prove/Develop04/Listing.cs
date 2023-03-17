using System;

class Listing : Activity {
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    private List<string> _input = new List<string>();
    public Listing() : base() {
        _frequency[2]++;
        _frequency[3]++;
        base._activityName = "Listing Activity";
        base._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public override void DoActivity() {
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Random rand = new Random();
        string chosenPrompt = _prompts[rand.Next(0, _prompts.Count)];
        Console.WriteLine(" ---- " + chosenPrompt + " ---- ");
        Console.Write("You may begin in: ");
        CountDown(_shortPause);
        Console.Write("\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            string listItem = Console.ReadLine();
            _input.Add(listItem);
        }
        Console.WriteLine("You listed " + _input.Count + " items!");
        Console.WriteLine("\nWell done!");
    }
    
}