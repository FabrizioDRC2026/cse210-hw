using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and exceeding requirements:
        // The program allows the user to choose a scripture category:
        // Book of Mormon, Doctrine and Covenants, Pearl of Great Price,
        // New Testament, or Old Testament.
        // Based on the user's choice, the program selects a scripture from that category.
        // Also, the program only hides words that are not already hidden.

        Console.Clear();

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine();
        Console.WriteLine("Choose which book you want to memorize from:");
        Console.WriteLine("1. Book of Mormon");
        Console.WriteLine("2. Doctrine and Covenants");
        Console.WriteLine("3. Pearl of Great Price");
        Console.WriteLine("4. New Testament");
        Console.WriteLine("5. Old Testament");
        Console.WriteLine();
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        Scripture selectedScripture;

        if (choice == "1")
        {
            Reference reference = new Reference("Ether", 12, 27);
            selectedScripture = new Scripture(
                reference,
                "And if men come unto me I will show unto them their weakness"
            );
        }
        else if (choice == "2")
        {
            Reference reference = new Reference("Doctrine and Covenants", 6, 36);
            selectedScripture = new Scripture(
                reference,
                "Look unto me in every thought doubt not fear not"
            );
        }
        else if (choice == "3")
        {
            Reference reference = new Reference("Moses", 1, 39);
            selectedScripture = new Scripture(
                reference,
                "For behold this is my work and my glory to bring to pass the immortality and eternal life of man"
            );
        }
        else if (choice == "4")
        {
            Reference reference = new Reference("John", 3, 16);
            selectedScripture = new Scripture(
                reference,
                "For God so loved the world that he gave his only begotten Son"
            );
        }
        else if (choice == "5")
        {
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            selectedScripture = new Scripture(
                reference,
                "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"
            );
        }
        else
        {
            Reference reference = new Reference("John", 3, 16);
            selectedScripture = new Scripture(
                reference,
                "For God so loved the world that he gave his only begotten Son"
            );
        }

        string userInput = "";

        while (userInput != "quit" && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                selectedScripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
    }
}