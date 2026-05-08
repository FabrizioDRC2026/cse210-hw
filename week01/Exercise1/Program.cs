using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is your first name? ");
      string firt_name = Console.ReadLine();

      Console.Write("What is your last name? ");
      string last_name = Console.ReadLine();
      Console.WriteLine();
      Console.Write($"Your name is {last_name}, {firt_name} {last_name}");
    }
}