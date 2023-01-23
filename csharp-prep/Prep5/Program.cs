using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int squareNumber(int userNumber) {
        return userNumber * userNumber;
    }
    static void DisplayResult(string name, int number) {
        Console.Write($"{name}, the square of your favorite number is {number}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = squareNumber(userNumber);
        
        DisplayResult(userName,squaredNumber);
    }
}