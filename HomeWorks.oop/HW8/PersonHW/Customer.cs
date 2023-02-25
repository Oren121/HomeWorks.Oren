using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PersonHW
{
    public class Customer : Person
    {
        public string ShippingAddress { get; set; } = "";

        public Customer(string shippingAddress) : base()
        {
            ShippingAddress = shippingAddress;
        }

        public Customer() : base()
        {
            ShippingAddress = "None";
        }
        public new void DisplayInfoToConsole()
        {
            string StringToReturn =
                $"Name:{Name}\n" +
                $"Age:{Age}\n" +
                $"Address:{Address}\n" +
                $"City:{City}\n" +
                $"Shipping Address:{ShippingAddress}\n";
            Console.Write(StringToReturn);
        }
    }
}
