using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class Main
    {
        public void Run()
        {

            Student student = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            University u1 = new University();
            Course course1 = new Course();
            Course course2 = new Course();
            u1.EnrollStudent(student2, course1);
            FacultyMember f1 = new FacultyMember();
            f1.AssignGrades(course2, student2);


        }
    }
}
