using System;

class Program
{
    static void Main(string[] args)
    {

        /*Console.WriteLine("what is your magic number?");
        string magicNumber = Console.ReadLine();
        int magicNumberValue = int.Parse(magicNumber);*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessValue = -1;

        while (guessValue != magicNumber)
        {
            Console.WriteLine("What is your guess");
            guessValue = int.Parse(Console.ReadLine());

            if (guessValue < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessValue > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it!");

        /* Random randomGenerator = new Random();
         int magicNumber = randomGenerator.Next(1, 101);

         int guess = -1;

         while (guess != magicNumber)
         {
             Console.Write("What is your guess? ");
             guess = int.Parse(Console.ReadLine());

             if (magicNumber > guess)
             {
                 Console.WriteLine("Higher");
             }
             else if (magicNumber < guess)
             {
                 Console.WriteLine("Lower");
             }
             else
             {
                 Console.WriteLine("You guessed it!");
             }
         }*/
    }
}