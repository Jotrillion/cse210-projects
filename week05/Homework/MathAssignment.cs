using System;

public class MathAssignment : Assignment
{
    private string _lesson;
    private string _numb;
    private string _subject;
    private string _range;

    public MathAssignment(string name, string topic, string lesson, string numb, string subject, string range) : base(name, topic)
    {
        _lesson = lesson;
        _numb = numb;
        _subject = subject;
        _range = range;
    }
    public string GetHomeworkList()
    {
        return $"{_lesson} {_numb} {_subject} {_range}";
    }


}