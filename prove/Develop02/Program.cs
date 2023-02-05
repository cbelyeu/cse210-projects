//stretch goal: I saved the file as, and loaded it from, a .csv

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //greet user
        Console.WriteLine("Welcome to the Journal Program!");
        //create journal
        Journal myJournal = new Journal();
        //display menu
        string MenuOption = "";
        do
        {
            Console.WriteLine("Please select one of the following options:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            //get userinput
            Console.Write("What would you like to do?: ");
            MenuOption = Console.ReadLine();
            switch (MenuOption)
            {
                case "1":
                    //write an entry
                    myJournal.CreateEntry();
                    break;
                case "2":
                    //display journal contents
                    myJournal.Display();
                    break;
                case "3":
                    //load journal from file
                    File LoadFile = new File();
                    LoadFile.Read(myJournal);
                    break;
                case "4":
                    //write to file
                    File SaveFile = new File();
                    SaveFile.Save(myJournal);
                    break;
                case "5":
                    //quit
                    break;
                default:
                    break;
            }
        } while (MenuOption != "5");
    }
}

class File
{
    string _fileName = "journal.csv";
    public void Save(Journal myJournal)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Entry myEntry in myJournal._entries) {
                outputFile.WriteLine($"{myEntry._timeStamp}|{myEntry._prompt}|{myEntry._text}");

            }
        }

    }
    public void Read(Journal myJournal) {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        myJournal._entries.Clear();
        foreach (string line in lines) {
            string[] parts = line.Split("|");
            myJournal.AddEntry(new Entry(parts[0],parts[1],parts[2]));
        }

    }
}

class Journal {
    public List<Entry> _entries = new List<Entry>();
    public void CreateEntry() {
        Entry newEntry = new Entry();
        AddEntry(newEntry);
    }
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }
    public void Display(){
        foreach(Entry myEntry in _entries) {
            myEntry.Display();
        }
    }
}
class Entry {
    public string _prompt = "";
    public string _text = "";
    public string _timeStamp = "";
    public Entry() {
        DateTime theCurrentTime = DateTime.Now;
        _timeStamp = theCurrentTime.ToShortDateString();
        //create promptlist
        PromptList myPromptList = new PromptList();
        _prompt = myPromptList.SelectPrompt();
        Console.Write($"{_prompt}: ");
        _text = Console.ReadLine();
    }
    public Entry(string timeStamp, string prompt, string text) {
        _timeStamp = timeStamp;
        _prompt = prompt;
        _text = text;
    }
    public void Display() {
        Console.WriteLine($"{_timeStamp}");
        Console.WriteLine($"{_prompt}"); 
        Console.WriteLine($"{_text}");
        Console.WriteLine("");
    }
}

class PromptList {
    private List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "If I had one thing I could do over today, what would it be?",
        "How have I seen the hand of the Lord in my life today?",
        "Who have a helped today?",
        "What was the best part of my day?"
    };
    Random _rand = new Random();

    public string SelectPrompt() {
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        return prompt;
    }
}