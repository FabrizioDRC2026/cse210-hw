using System;

// Creativity: Added level titles based on score so the player has extra motivation
// beyond only collecting points.
public class Program
{
    public static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}