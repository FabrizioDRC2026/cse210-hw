using System;

// Creativity / Exceeding Requirements:
// 1. The program saves a simple log file called activity_log.txt.
// 2. The program shows how many total activities were completed during the session.
// 3. Reflection questions are shuffled so the same question is not repeated until all questions have been used once.

class Program
{
    static void Main(string[] args)
    {
        int sessionCount = 0;
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                activity = new ReflectionActivity();
            }
            else if (choice == "3")
            {
                activity = new ListingActivity();
            }
            else if (choice == "4")
            {
                ActivityLog.ShowLog();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine($"\nYou completed {sessionCount} activities during this session.");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Press Enter to try again.");
                Console.ReadLine();
            }

            if (activity != null)
            {
                activity.Run();
                sessionCount++;
                ActivityLog.Save(activity.GetName(), activity.GetDuration());
            }
        }
    }
}