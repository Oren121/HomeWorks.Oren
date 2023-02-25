using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PersonHW
{
    public class Employe : Person
    {
        public Employe() : base()
        {
            Department = "None";
            Salery = 0;
        }

        public Employe(int age, string name, string address, string city, string department, int salery) : base(age, name, address, city)
        {
            Department = department;
            Salery = salery;
        }

        public string Department { get; set; } = "";
        public int Salery { get; set; }

        public new void DisplayInfoToConsole()
        {
            string StringToReturn =
                $"Name:{Name}\n" +
                $"Age:{Age}\n" +
                $"Address:{Address}\n" +
                $"City:{City}\n" +
                $"Department:{Department}\n" +
                $"Salery:{Salery} \n";
            Console.Write(StringToReturn);
        }
    }
}
