using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public abstract class Person
    {
        protected Person()
        {
            FirstName = "firstName";
            LastName = "lastName";
            Age = 0;
        }

        protected Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public abstract void DisplayInfo();
    }
}
