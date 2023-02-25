using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PersonHW
{
    public class Student : Person
    {
        public Student()
        {
            StudyClass = "";
            Type = StudentType.None;
        }

        public Student(int age, string name, string address, string city, string studyClass, StudentType type) : base(age, name, address, city)
        {
            StudyClass = studyClass;
            Type = type;
        }

        public string StudyClass { get; set; }
        public StudentType Type { get; set; }

        public new void DisplayInfoToConsole()
        {
            string StringToReturn =
                $"Name:{Name}\n" +
                $"Age:{Age}\n" +
                $"Address:{Address}\n" +
                $"City:{City}\n" +
                $"Study Class:{StudyClass}\n" +
                $"Student Type:{Type}\n";
            Console.Write(StringToReturn);
        }

        public enum StudentType
        {
            Inner,
            External,
            None
        }
    }
}
