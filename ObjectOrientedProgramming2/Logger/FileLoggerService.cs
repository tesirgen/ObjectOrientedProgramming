using ObjectOrientedProgramming2.Interface;
using System;

namespace ObjectOrientedProgramming2
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
