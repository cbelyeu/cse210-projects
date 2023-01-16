using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageString = Console.ReadLine();
        int percentInt = int.Parse(percentageString);
        string letter = "F";
        if (percentInt >= 90) {
            letter = "A";
        }
        else if (percentInt >= 80) {
            letter = "B";

        }
        else if (percentInt >= 70) {
            letter = "C";
        }
        else if (percentInt >= 60) {
            letter = "D";
        }

        string plusOrMinus = "";
        if (letter != "F")
        {
            int lastDigit = percentInt % 10;
            if (lastDigit >= 7 && percentInt < 97)
            {
                plusOrMinus = "+";
            }
            else if (lastDigit < 3 && percentInt <= 93)
            {
                plusOrMinus = "-";
            }
        }
        
        Console.WriteLine($"Your grade is: {letter}{plusOrMinus}");
        if (percentInt >= 70) {
            Console.WriteLine("Congratulations! You passed!");
        }
        else {
            Console.WriteLine("You didn't pass the class, but there's always retaking!");
        }
    }
}