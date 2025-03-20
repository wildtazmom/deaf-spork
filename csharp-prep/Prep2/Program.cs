using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your test scre? ");
        string score1 = Console.ReadLine();
        
        int letter = int.Parse(score1);


        if (letter >= 95)
        {
            score1 = "You get an A";
        }
        else if (letter >= 85)
        {
            score1 = "You get a B";
        }
        else if (letter >= 75)
        {
            score1 = "You get a C";
        }
        else if (letter >= 65)
    {
           score1 = "You get a D";
    }
        else
    {
         score1 = "F";
    }
    Console.WriteLine($"The grade is {score1}, and if you get a F, please see the instructor.");





       

        
        
        
        

    }
}