using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "0";
        Quest myQuest = new Quest();
        do {
            Console.WriteLine($"\nYou have {myQuest.GetPoints()} points.\n");
            Console.Write("Menu:\n\t1. Create Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nSelect a choice from the menu: ");
            userInput = Console.ReadLine();
            switch(userInput) {
                case "1":
                    myQuest.CreateGoal();
                    break;
                case "2":
                    Console.Write(myQuest.PrintList());
                    break;
                case "3":
                    Console.Write("What is the filename you'd like to save to? ");
                    string goalFile = Console.ReadLine();
                    myQuest.SaveToFile(goalFile);
                    break;
                case "4":
                    Console.Write("What is the filename you'd like to load from? ");
                    string goalstore = Console.ReadLine();
                    myQuest.LoadGoals(goalstore);
                    break;
                case "5":
                    Console.WriteLine("Congratulations! You have earned " + myQuest.RecordEvent() + " points!");
                    Console.WriteLine("You now have " + myQuest.GetPoints() + " points!");
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("I'm sorry, I didn't get that.");
                    break;
            }

        } while (userInput != "6");
    }
}