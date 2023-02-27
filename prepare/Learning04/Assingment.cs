using System;
namespace library 
{



public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment( string studentName)
    {
        _studentName=studentName;
    }
    public string GetSummary()

    {
        return _studentName + _topic;
    }
    public string GetstudentName()
    {
        return _studentName;
    }
    public void SetstudentName(String studentName)
    {
        _studentName=studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic=topic;
    }
}
}