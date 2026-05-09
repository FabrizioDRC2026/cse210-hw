using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentage? ");
        float grade = float.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your grade is F");
        }
        else
        {
            Console.WriteLine("Please enter a valid percentage");
        }
    }
}