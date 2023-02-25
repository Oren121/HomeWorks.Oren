using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PersonHW
{
    public class HW8OOP
    {
        public static void Run()
        {
            Person p1 = new Person();
            Customer c1 = new Customer();
            Employe e1 = new Employe();
            Student s1 = new Student();
            Person[] presons = { new Person(), new Person(), new Person(), new Person(), new Person() };
            p1.DisplayInfoToConsole();
            c1.DisplayInfoToConsole();
        }
    }
}
