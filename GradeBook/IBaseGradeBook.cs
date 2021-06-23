using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public interface IBaseGradeBook
    {
        List<Student> Students { get; set; }
    }
}
