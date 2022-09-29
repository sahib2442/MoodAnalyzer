using System;
namespace MoodAnaly
{
    class program
    {
        static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string message = mood.Analyse();
        }
    }
}
