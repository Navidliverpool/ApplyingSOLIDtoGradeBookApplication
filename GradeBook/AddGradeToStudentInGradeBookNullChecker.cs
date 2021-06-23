﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    public class AddGradeToStudentInGradeBookNullChecker : IBaseGradeBook
    {
        private readonly Logger _logger;
        public List<Student> Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AddGradeToStudentInGradeBookNullChecker(Logger logger)
        {
            _logger = logger;
        }

        public void CheckIfStudentQueryIsNull(string name)
        {
            var student = Students.FirstOrDefault(e => e.Name == name);
            if (student == null)
            {
                _logger.log("Student {0} was not found, try again.", name);
                return;
            }
        }
    }
}
