using System;
using System.IO;

class Quest {
    int _points = 0;
    List<Goal> _goals = new List<Goal>();
    public int GetPoints() {
        return _points;
    }
    public Goal CreateGoal(){
        Console.Write("The types of goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhich type of Goal would you like to create? ");
        Goal newGoal = null;
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal?: ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine();
        Console.Write("How many points do you want to associate with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        switch(goalType) {
            case 1:
                //the Goal is a simple Goal
                newGoal = new Goal(goalName, goalDesc, goalPoints);
                break;
            case 2:
                //this goal is an Eternal goal
                newGoal = new Eternal(goalName, goalDesc, goalPoints);
                break;
            case 3:
                //this goal is a checklist goal
                Console.Write("How many times does this goal need to be fulfilled for a bonus? ");
                int goalReps = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int goalBonus = int.Parse(Console.ReadLine());
                newGoal = new Checklist(goalName, goalDesc, goalPoints, goalReps, goalBonus);
                break;
            default:
                break;
        }
        _goals.Add(newGoal);
        return newGoal;
    }

    public string PrintList() {
        string listString = "\nThe goals are:\n";
        for(int i = 0; i < _goals.Count();i++){
            Goal entry = _goals[i];
            listString += i+1 + ". " + entry.PrintGoal() + "\n";
        }
        return listString;
    }

    public void SaveToFile(string fileName) {
        string allGoalsString = _points + "\n";
        for(int i = 0;i< _goals.Count();i++) {
            string currentGoalString = _goals[i].GoalToString();
            allGoalsString += currentGoalString + "\n";
        }
        File.WriteAllText(fileName, allGoalsString);
    }

    public void LoadGoals(string fileName) {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _goals.Clear();
        _points = int.Parse(lines[0]);
        //begin iterating at the second line, the first line has the number of points.
        for(int i = 1; i < lines.Count(); i++) {
            var line = lines[i];
            string[] lineParts = line.Split("|");
            switch(lineParts[0]) {
                case "1":
                    //Simple Goal storage format: name(string), description(string), points(int), 
                    //completed(bool)
                    Goal SimpleGoal = new Goal(lineParts[1], lineParts[2],int.Parse(lineParts[3]));
                    SimpleGoal.SetCompletion(bool.Parse(lineParts[4]));
                    _goals.Add(SimpleGoal);
                    break;
                case "2":
                    //Eternal Goal storage format: name(string), description(string), points(int), 
                    //completed(bool)
                    Goal EternalGoal = new Eternal(lineParts[1], lineParts[2],int.Parse(lineParts[3]));
                    EternalGoal.SetCompletion(bool.Parse(lineParts[4]));
                    _goals.Add(EternalGoal);
                    break;
                case "3":
                    //Checklist Goal storage format: name(string), description(string), points(int), 
                    //completed(bool), repetitions(int), finishedRepetitions(int), bonus(int)
                    string name = lineParts[1];
                    string desc = lineParts[2];
                    int points = int.Parse(lineParts[3]);
                    bool completedStatus = bool.Parse(lineParts[4]);
                    int repetitions = int.Parse(lineParts[5]);
                    int finishedReps = int.Parse(lineParts[6]);
                    int bonus = int.Parse(lineParts[7]);
                    Checklist CheckGoal = new Checklist(name, desc, points, repetitions, bonus);
                    CheckGoal.SetCompletion(completedStatus);
                    CheckGoal.SetFinishedRepetitions(finishedReps);
                    _goals.Add(CheckGoal);
                    break;
            }
        }
    }

    public int RecordEvent() {
        Console.Write(PrintList());
        Console.Write("Which goal did you accomplish?: ");
        int goalIndex = int.Parse(Console.ReadLine());
        //figure out which goal is referred to:
        int pointsEarned = _goals[goalIndex-1].RecordCompletion();
        _points += pointsEarned;
        return pointsEarned;
    }
}