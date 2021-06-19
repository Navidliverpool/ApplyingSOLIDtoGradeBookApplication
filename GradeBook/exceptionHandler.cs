using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class exceptionHandler
    {
        public void HandleException(string message)
        {
             throw new ArgumentException(message);
        }

        public void HandleException(string message, double lowestGrade, double highestGrade)
        {
            throw new ArgumentException(message);
        }
    }
}
