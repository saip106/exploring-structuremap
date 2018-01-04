using System;

namespace StructureMap.Sample
{
    public interface ILogger
    {
        void Log(string input);
    }

    public class Logger : ILogger
    {
        public void Log(string input)
        {
            Console.WriteLine(input);
        }
    }
}