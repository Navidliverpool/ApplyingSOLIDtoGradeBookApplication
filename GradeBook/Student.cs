using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using GradeBook.Enums;

namespace GradeBook
{
    public class Student
    {
        private readonly StudentGradeCollectioner _studentGradeCollectioner;
        private readonly exceptionHandler _exceptionHandler;
        private readonly Logger _logger;
        public string Name { get; set; }
        public StudentType Type { get; set; }
        public EnrollmentType Enrollment { get; set; }
        //public List<double> Grades { get; set; }
        public List<Student> Students { get; set; }
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
        public Student(Logger logger, exceptionHandler exceptionHandler, StudentGradeCollectioner studentGradeCollectioner)
        {
            _logger = logger;
            _exceptionHandler = exceptionHandler;
            _studentGradeCollectioner = studentGradeCollectioner;
    }

        public Student(string name, StudentType studentType, EnrollmentType enrollment)
        {
            Name = name;
            Type = studentType;
            Enrollment = enrollment;
        }

        public void AddGrade(double grade, double minimumGrade, double maximunGrade)
        {
            if (grade < minimumGrade || grade > maximunGrade)
            _exceptionHandler.HandleException("Grades must be between {i} and {j}." , minimumGrade, maximunGrade);
            _studentGradeCollectioner.Grades.Add(grade);
        }

        public void RemoveGrade(double grade)
        {
            _studentGradeCollectioner.Grades.Remove(grade);
        }

        public void AddStudent(Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
            _exceptionHandler.HandleException("A Name is required to add a student to a gradebook.");
            Students.Add(student);
        }

        public void RemoveStudent(string name)
        {
            if (string.IsNullOrEmpty(name))
            _exceptionHandler.HandleException("A Name is required to remove a student from a gradebook.");
            var student = Students.FirstOrDefault(e => e.Name == name);

            if (student == null)
            {
                _logger.log("Student {0} was not found, try again.", name);
                return;
            }
            Students.Remove(student);
        }

    }
}
