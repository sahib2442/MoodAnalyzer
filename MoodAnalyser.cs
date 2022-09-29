using System;
namespace MoodAnaly
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }
        public string Analyse()
        {
            try
            {
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }catch(NullReferenceException ex)
            {
                return ex.Message;
            }
        }
    }
}
