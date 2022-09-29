using System.Runtime.Serialization;

namespace MoodAnaly
{
    [Serializable]
    internal class MoodAnalyserCustomException : Exception
    {
        private object nO_SUCH_CLASS;
        private string v;

        public MoodAnalyserCustomException()
        {
        }

        public MoodAnalyserCustomException(string? message) : base(message)
        {
        }

        public MoodAnalyserCustomException(object nO_SUCH_CLASS, string v)
        {
            this.nO_SUCH_CLASS = nO_SUCH_CLASS;
            this.v = v;
        }

        public MoodAnalyserCustomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}