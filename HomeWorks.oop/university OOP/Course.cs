using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class Course
    {
        public Course()
        {
            CourseCode = 000;
            CourseName = "";
        }
        public Course(int courseCode, string courseName, Faculty faculty, List<Student> studentList)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Faculty = faculty;
            StudentList = studentList;
        }
        public Course(int courseCode, string courseName, Faculty faculty)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Faculty = faculty;
        }
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public Faculty Faculty { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student> { };
        public List<double> GradePoints { get; set; } = new List<double> { };


    }
}
