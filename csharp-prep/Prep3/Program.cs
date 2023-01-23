using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1;
        do
        {
            Console.Write("What is your guess? "); 
            guessNumber = int.Parse(Console.ReadLine());
            if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        } while (guessNumber != magicNumber);
    }
}