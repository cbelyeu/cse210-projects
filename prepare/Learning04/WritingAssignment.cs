using System;

class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName,string topic,string title) : base(studentName,topic){
        _title = title;
    }
    public override string GetSummary() {
        return base.GetSummary() + "\n" + GetWritingInformation();
    }
    public string GetWritingInformation() {
        return _title + " by " + _studentName;
    }
}