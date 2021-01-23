using ObjectOrientedProgramming2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming2
{
    public class DatabaseLoggerService:ILoggerService
    {
        public void Log() 
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
