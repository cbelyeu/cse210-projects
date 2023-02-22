using System;

class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        string UserInput = "";
        ScriptureLibrary myLibrary = new ScriptureLibrary();
        Scripture myScripture = myLibrary.ChooseRandom();
        Console.WriteLine(myScripture.ScriptureToString());
        UserInput = Console.ReadLine();
        while(UserInput != "quit"){
            myScripture.HideOneWord();
            Console.WriteLine(myScripture.ScriptureToString());
            UserInput = Console.ReadLine();
            if(myScripture.GetHidden()) {
                UserInput = "quit";
            }
        };
    }
}