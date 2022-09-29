using System;
namespace MoodAnaly
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,EMPTY_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalysisException(ExceptionType type,string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
