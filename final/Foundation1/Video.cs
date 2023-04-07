using System;

class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CountCommments() {
        return _comments.Count();
    }

    public void AddComment(string name, string text) {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }

    public string VidToString() {
        string vidString = "\n" + _title + "\n" + _author + "\n" + _length + " seconds\n" + CountCommments() + " Comments:\n";
        foreach(Comment myComment in _comments) {
            vidString += myComment.GetName() + ": " + myComment.GetText() + "\n";
        }
        return vidString;
    }
}