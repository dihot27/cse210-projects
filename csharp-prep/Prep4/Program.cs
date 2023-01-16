using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        int i,n,sum=0;
        Console.Write("Enter your numbers");
        for(i=1;i<=8;i++)
        {
            Console.Write("Number-{0}:",i);
            n=Convert.ToInt32(Console.ReadLine());
            sum+=n;
        }

    }
}