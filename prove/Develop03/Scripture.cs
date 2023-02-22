using System;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _reference;
    private bool _allHidden = false;
    public Scripture(Reference reference) {
        _reference = reference.GetVerseNumber();
        List<string> wordStrings = reference.GetText();
        for(int i = 0;i<wordStrings.Count();i++) {
            Word newWord = new Word(wordStrings[i]);
            _words.Add(newWord);
        }
    }

    public string ScriptureToString() {
        string result = _reference + "\n";
        for(int i = 0; i<_words.Count();i++) {
            result += _words[i].WordToString() + " ";
        }
        return result;
    }
    public void HideOneWord() {
        var random = new Random();
        int index = random.Next(_words.Count());
        if(!_words[index].GetHidden()) {
            _words[index].SetHidden();
        } else {
            index = random.Next(_words.Count());
            if(!_words[index].GetHidden()) {
                _words[index].SetHidden();
            } else {
                //to get here, I had to get two results that were already hidden.
                //It's a good idea to evaluate whether all of the words are hidden
                _allHidden = true;
                for(int i = 0;i < _words.Count();i++) {
                    if(!_words[i].GetHidden()) {
                        if(_allHidden == true) {
                            //This is the first result that is not already hidden,
                            //thus _allHidden's value hasn't been changed yet
                            _words[i].SetHidden();
                        }
                        _allHidden = false;
                    }
                }
            }
        }
    }

    public bool GetHidden() {
        return _allHidden;
    }
    
}