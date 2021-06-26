using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Logger
    {
        private readonly StudentNameTypeEnrollmentHolder _studentNameTypeEnrollmentHolder;
        public Logger(StudentNameTypeEnrollmentHolder studentNameTypeEnrollmentHolder)
        {
            _studentNameTypeEnrollmentHolder = studentNameTypeEnrollmentHolder;
        }

       public void log(string message)
        {
            Console.WriteLine(message);
        }
       
        public void log(string message1, string message2)
        {
            Console.WriteLine(message1, message2);
        }

        public void log(string message1, StudentNameTypeEnrollmentHolder name, StudentNameTypeEnrollmentHolder type, StudentNameTypeEnrollmentHolder enrollment)
        {
            Console.WriteLine(message1, name, type, enrollment);
        }
    }
}
