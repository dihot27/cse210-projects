using System;
namespace library 
{
 public class MathAssignment:Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems=problems;
    }
    public string GetHomeworkList()

    {
        return "{_textBookSection}+ {_problems}";
    }
    
}
}