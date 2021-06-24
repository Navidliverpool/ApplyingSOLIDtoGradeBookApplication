using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class AddRemoveStudents
    {
        private readonly exceptionHandler _exceptionHandler;
        public AddRemoveStudents(exceptionHandler exceptionHandler)
        {
            _exceptionHandler = exceptionHandler;
        }

        public void StudentNameNullCheckForAddRemoveStudents(Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
                _exceptionHandler.HandleException("A Name is required to add a student to a gradebook.");
            return;
        }
    }
}
