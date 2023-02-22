using System;
using System.IO;

class ScriptureLibrary
{
    private List<Scripture> _library = new List<Scripture>();
    public ScriptureLibrary(){
        if(File.Exists("ScriptureList.txt")){
            string[] lines = File.ReadAllLines("ScriptureList.txt");
            for(int i = 0; i < lines.Length;i+=2) {
                Reference myReference = new Reference(lines[i],lines[i+1]);
                Scripture myScripture = new Scripture(myReference);
                _library.Add(myScripture);
            }
        }
    }
    public Scripture ChooseRandom() {
        var random = new Random();
        int index = random.Next(_library.Count());
        return _library[index];
    }
    public string AllScripturesToString() {
        string result = "";
        for(int i = 0; i < _library.Count();i++) {
            result += _library[i].ScriptureToString() + "\n";
        }
        return result;
    }
}