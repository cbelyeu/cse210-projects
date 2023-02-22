using System;

class Reference
{
    private string _reference;
    private List<string> _text = new List<string>();
    public Reference(string reference, string text) {
        _reference = reference;
        text = text.Replace("@",System.Environment.NewLine);
        string[] newWords = text.Split(" ");
        for(int i = 0; i < newWords.Count(); i++){
            _text.Add(newWords[i]);
        }
    }
    public List<string> GetText() {
        return _text;
    }
    public string GetVerseNumber() {
        return _reference;
    }
}