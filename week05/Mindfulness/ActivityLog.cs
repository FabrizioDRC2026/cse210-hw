using System;
using System.IO;

public static class ActivityLog
{
    private static string _fileName = "activity_log.txt";

    public static void Save(string activityName, int duration)
    {
        string logEntry = $"{DateTime.Now}: {activityName} completed for {duration} seconds.";
        File.AppendAllText(_fileName, logEntry + Environment.NewLine);
    }

    public static void ShowLog()
    {
        Console.Clear();
        Console.WriteLine("Activity Log");
        Console.WriteLine("============\n");

        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);

            if (lines.Length == 0)
            {
                Console.WriteLine("No activities have been logged yet.");
            }
            else
            {
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("No activities have been logged yet.");
        }
    }
}