using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class MethodParameterNullCheckerGradeBook
    {
        private readonly Logger _logger;
        public MethodParameterNullCheckerGradeBook(Logger logger)
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