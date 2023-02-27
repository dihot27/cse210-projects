using System;
namespace library
{

class Program
 {
    static void Main(string[] args)
    {
        Assignment assignment= new Assignment("Tlhabanelo Diholo", "M");
        assignment.GetstudentName();
        assignment.GetSummary();
        assignment.GetTopic();
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment=new MathAssignment("Tlhabanelo Diholo", "Fraction","7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment=new WritingAssignment("Many waters", "European History", "The Cause Of worls War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
    
  }
}