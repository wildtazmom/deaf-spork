using System;

{
Console.WriteLine("Hello Prep3 World!");
Console.WriteLine("You will be playing a game called Guess the Number.");

Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);
int secretNumber = -1;
//Needs fixing again
while (secretNumber != magicNumber)
{
   {
    // Create the if statements
     Console.WriteLine("What is your guess? ");
     secretNumber = int.Parse(Console.ReadLine());
           
    if (magicNumber > secretNumber)
       {
        Console.WriteLine("Higher");
       }
    else if (magicNumber < secretNumber)
        {
        Console.WriteLine("Lower");
        }
    else
    {
       Console.WriteLine("Huzzah!");
       Console.WriteLine($"You have guessed it!");
    }
   }

   
}
}
