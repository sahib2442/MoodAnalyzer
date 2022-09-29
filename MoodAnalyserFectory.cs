using System;
using System.Reflection;
using System.Text.RegularExpressions;
namespace MoodAnaly
{
    public class MoodAnalyserFectory
    {
        private static object? exeuting;

        public static object? MoodAnalyseType { get; private set; }

        public static object CreateMoodAnalyse(string className,string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = exeuting.GetType(className);
                    return Activator.CreateInstance((Type)MoodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS,"Class Not Fount");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Fount");
            }
        }
    }
}
