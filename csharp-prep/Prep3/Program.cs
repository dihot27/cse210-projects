using System;

class Program
{
    static void Main(string[] args)

       
    {

         
        Random randomGenerator= new Random();
        int number= randomGenerator.Next(1,100);
        int magic=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your guess?");
        int guess=Convert.ToInt32(Console.ReadLine());
        while(magic!=guess)
        
        {
            Console.WriteLine("What is your guess?");
            
        }

        if(magic>guess)
        
        {
            Console.WriteLine("Higher");

        }
        if(magic<guess)
        {
            Console.WriteLine("Lower");
        }
        else if(magic==guess)
        {
            Console.WriteLine("You guessed it!");
        }
        
}
}

