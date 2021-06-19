using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public interface IStudent
    {
       void AddGrade(double grade, double minimumGrade, double maximunGrade);
    }
}
