using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Logger
    {
       public void log(string message)
        {
            Console.WriteLine(message);
        }
       
        public void log(string message1, string message2)
        {
            Console.WriteLine(message1, message2);
        }
    }
}
