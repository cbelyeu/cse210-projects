using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssignment = new Assignment("Joquavius the Third", "World Domination");
        Console.WriteLine("\n" + simpleAssignment.GetSummary());
        MathAssignment M = new MathAssignment("Pickles", "Regret", "78970","2.3-4.8");
        Console.WriteLine("\n" + M.GetSummary());
        WritingAssignment W = new WritingAssignment("Calvin","Creative Writing","The Continued Adventures of Spaceman Spiff");
        Console.WriteLine("\n" + W.GetSummary() + "\n");
    }
}