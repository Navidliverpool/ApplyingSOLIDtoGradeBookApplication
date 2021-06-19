using GradeBook.GradeBooks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GradeBook
{
    public class GradeBookLoader
    {
        private readonly Logger _logger;
        public GradeBookLoader(Logger logger)
        {
            _logger = logger;
        }

       public BaseGradeBook Load(string name)
        {
            if (!File.Exists(name + ".gdbk"))
            {
                _logger.log("Gradebook could not be found.");
            }
            return null;
        } 
    }
}
