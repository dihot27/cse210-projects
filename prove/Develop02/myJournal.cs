using System;
using System.Text;
using System.IO;
using static System.Console;

namespace JournalApp
{
class myJournal
{
     private string journalFile="Journal.txt";

     public void Run()
    {
       DisplayIntro();
       DisplayOutro();
    }
     private void DisplayIntro()
     {
        ForegroundColor=ConsoleColor.Black;
        BackgroundColor=ConsoleColor.White;
        WriteLine("Welcome to my journal");
        ReadKey(true);
     }
     private void  CreateJournalFile(){}
     private void  RunMenu(){}
     private void DisplayOutro()
     {
         WriteLine("Have a good day");
        ReadKey(true);

     }
     private void  DisplayJournalContents(){}

     private void ClearFile() {}
     private void AddEntry(){}
    
    public void RunMenu(){}
}
}




