using System;
namespace Mood_Analyser_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Problem!");
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();
            MoodAnalyser checkMood = new MoodAnalyser(message);
            string result = checkMood.AnalyseMood(message);
            Console.WriteLine(result + " MOOD");
        }
    }
}
