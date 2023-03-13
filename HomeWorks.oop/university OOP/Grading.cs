using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class Grading
    {
        public static double CalculateGPA(List<Course> courses, Student student)
        {
            double totalCredits = 0;
            double totalGradePoints = 0;

            foreach (Course course in courses)
            {
                if (course.StudentList.Contains(student))
                {
                    double credits = 3; // assume each course is worth 3 credits
                    double gradePoints = course.Faculty.AssignGrades(course, student);
                    totalCredits += credits;
                    totalGradePoints += gradePoints;
                }
            }

            return totalGradePoints / totalCredits;
        }
    }
}
