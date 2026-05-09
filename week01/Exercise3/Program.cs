using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,11);
        int guess = -1;
        int attempts = 0;

        while (randomNumber != guess)
        {
            Console.Write("Guess the number? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You Guess it! it took you {attempts} times to guess it!");
                
            }

        }

    }
}