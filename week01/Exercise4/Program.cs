using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int finish = -1;

        while (finish != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");

            finish = int.Parse(Console.ReadLine());

            if (finish != 0)
            {
                numbers.Add(finish);
            }
        }

        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}