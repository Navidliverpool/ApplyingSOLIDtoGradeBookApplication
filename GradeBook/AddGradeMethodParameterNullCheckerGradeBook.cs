using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class AddGradeMethodParameterNullCheckerGradeBook
    {
        private readonly Logger _logger;
        public AddGradeMethodParameterNullCheckerGradeBook(Logger logger)
        {
            _logger = logger;
        }
        public void StudentNameCheckForNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            _logger.log("A Name is required to add a grade to a student.");
            return;
        }
    }
}