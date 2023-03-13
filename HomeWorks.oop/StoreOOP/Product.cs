using Demos.HackerU.HomeWorks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorks.oop.StoreOOP
{
    public class Product
    {
        private static int _Id = 0;
        private readonly string PrefixId = "";
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Isinstock { get; set; }
        public string CategoryId { get; set; }

        public Product(string prefixId, string name, decimal price, bool isinstock, string categoryId)
        {
            _Id++;
            PrefixId = prefixId;
            Id = prefixId + "#" + _Id;
            Name = name;
            Price = price;
            Isinstock = isinstock;
            CategoryId = categoryId;
        }

        public Product(string name, decimal price, bool isinstock, string categoryId)
        {
            _Id++;
            CategoryId = categoryId;
            Id = CategoryId + "#" + _Id;
            Name = name;
            Price = price;
            Isinstock = isinstock;

        }

        public Product()
        {
            _Id++;
            CategoryId = "0";
            Id = CategoryId + "" + _Id.ToString();
            Name = "";
            Price = 0;
            Isinstock = false;
        }
        public static Product CopyProductWithNewId(Product exsistingProduct)
        {

            Product product = new Product(exsistingProduct.PrefixId, exsistingProduct.Name, exsistingProduct.Price, exsistingProduct.Isinstock, exsistingProduct.CategoryId);
            return product;
        }
        public override string ToString()
        {
            string StringToReturn = $"ID:{Id} \n" +
                $"Catogory Id:{CategoryId}\n" +
                $"Name:{Name}\n" +
                $"Price:{Price}\n" +
                $"in stock:{Isinstock}\n";
            return StringToReturn + base.ToString();
        }
    }
}
