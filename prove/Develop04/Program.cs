//How I displayed creativity: 
//I added an option for the user to view how many Activities total they did, 
//as well as how many of each type.
//I also updated the CountDown function to be able to handle two-digit numbers if required.

using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "0";
        Console.Clear();
        do{
            Console.Write("Menu Options\n  1. Breathing Activity.\n  2. Reflecting Activity.\n  3. Listing Activity.\n  4. View your stats!\n  5. Quit.\nSelect a choice from the menu: ");
            userInput = Console.ReadLine();
            Activity userActivity = new Activity();
            bool validInput = true;
            switch(userInput) {
                case "1":
                    //breathing activity
                    userActivity = new Breathing();
                    break;
                case "2":
                    //reflection activity
                    userActivity = new Reflection();
                    break;
                case "3":
                    //listing activity
                    userActivity = new Listing();
                    break;
                case "4":
                    //report your stats!
                    userActivity.ReportFrequency();
                    //This is to tell the program that an Activity was not selected.
                    validInput = false;
                    break;
                default:
                    //This will also handle the exit program option
                    validInput = false;
                    break;
            }
            if(validInput) {
                userActivity.ActivitySequence();
            }
        } while(userInput != "5");
    }
}