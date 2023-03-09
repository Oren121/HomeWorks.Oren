using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class University
    {
        public List<Course> Courses { get; set; }
        public void EnrollStudent(Student student, Course course)
        {
            course.StudentList.Add(student);
            student.CoursesList.Add(course);
        }
    }
}
