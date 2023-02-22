using System;
using System.Text.RegularExpressions;

class Word {
    private string _text;
    private bool _hidden;
    private int _length;

    public Word(string text) {
        _text = text;
        _hidden = false;
        _length = text.Length;
    }
    public void SetHidden() {
        _hidden = true;
    }
    public bool GetHidden() {
        return _hidden;
    }
    public string WordToString(){
        string result = _text;
        if (_hidden){
            result = Regex.Replace(_text,"[A-Za-z]","_");
        }
        return result;
    }
}