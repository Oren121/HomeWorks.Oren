using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorks.oop.HW8.PersonHW
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public Person(int age, string name, string address, string city)
        {
            Age = age;
            Name = name;
            Address = address;
            City = city;
        }

        public Person()
        {
            Age = 0;
            Name = "None";
            Address = "None";
            City = "None";
        }
        public void DisplayInfoToConsole()
        {
            string StringToReturn =
                $"Name:{Name}\n" +
                $"Age:{Age}\n" +
                $"Address:{Address}\n" +
                $"City:{City}\n";
            Console.Write(StringToReturn);
        }
    }

}
