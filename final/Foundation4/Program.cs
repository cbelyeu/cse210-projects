using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> exercises = new List<Activity>();
        Running a1 = new Running(120, 2);
        Cycling a2 = new Cycling(60,2);
        Swimming a3 = new Swimming(60,1);
        exercises.Add(a1);
        exercises.Add(a2);
        exercises.Add(a3);
        foreach(Activity exercise in exercises) {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}