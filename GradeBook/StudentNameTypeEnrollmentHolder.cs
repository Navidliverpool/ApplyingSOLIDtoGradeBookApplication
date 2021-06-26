using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook
{
    public class StudentNameTypeEnrollmentHolder
    {
        public StudentType Type { get; set; }
        public EnrollmentType Enrollment { get; set; }
        public string Name { get; set; }
    }
}
