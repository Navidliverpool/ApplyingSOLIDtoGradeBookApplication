using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using GradeBook.Enums;

namespace GradeBook
{
    public class Student
    {
        private readonly MinMaxGradeDefinder _minMaxGradeDefinder;
        private readonly StudentGradeCollectioner _studentGradeCollectioner;
        private readonly exceptionHandler _exceptionHandler;
        private readonly Logger _logger;
        [JsonIgnore]
        public char LetterGrade { get; set; }
        [JsonIgnore]
        public double GPA { get; set; }
        [JsonIgnore]
        public double AverageGrade
        {
            get
            {
                return _studentGradeCollectioner.Grades.Average();
            }
        }
        public Student(Logger logger, exceptionHandler exceptionHandler, StudentGradeCollectioner studentGradeCollectioner, MinMaxGradeDefinder minMaxGradeDefinder)
        {
            _logger = logger;
            _exceptionHandler = exceptionHandler;
            _studentGradeCollectioner = studentGradeCollectioner;
            _minMaxGradeDefinder = minMaxGradeDefinder;
        }

        public void AddGrade(double grade)
        {            
            if (grade < _minMaxGradeDefinder.MinimumGrade || grade > _minMaxGradeDefinder.MaximumGrade)
            _exceptionHandler.HandleException("Grades must be between {i} and {j}." , _minMaxGradeDefinder.MinimumGrade, _minMaxGradeDefinder.MaximumGrade);
            _studentGradeCollectioner.Grades.Add(grade);
        }

        public void RemoveGrade(double grade)
        {
            _studentGradeCollectioner.Grades.Remove(grade);
        }

      

    }
}
