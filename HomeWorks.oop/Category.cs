using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public string GetAsText()
        {
            string StringToReturn = "";
            string DataString = "";
            Products.ForEach(word => { DataString += word.GetAsText() + "\n"; });
            DataString = DataString.TrimEnd(',');
            StringToReturn = $"Id:{Id} \nTitle:{Title} \nProducts:{DataString}";
            return StringToReturn;
        }
        public string GetAsTextShort()
        {
            string StringToReturn = "";
            StringToReturn = $"Id:{Id} \nTitle:{Title}";
            return StringToReturn;
        }
        public void AddProduct(Product newProductToAdd)
        {
            Products.Add(newProductToAdd);
        }
        public void AddProducts(Product[] productsToAdd)
        {
            foreach (Product product in productsToAdd)
            {
                Products.Add(product);
            }
        }
        public Product GetProductById(int id)
        {
            Product p1 = new Product();
            foreach (Product product in Products)
            {
                if (product.Id == id) p1 = product;
            }
            return p1;
        }
        public Product GetProductByTitle(string title)
        {
            Product p1 = new Product();
            int index = Products.FindIndex(x => x.Title == title);
            p1 = Products[index];
            return p1;
        }
        public List<Product> FindAllProductsByKeyWord(string keyword)
        {
            List<Product> productsToReturn = new List<Product>();
            foreach (Product product in Products)
            {
                foreach (var search in product.Keywords)
                {
                    if (search == keyword)
                    {
                        productsToReturn.Add(product);
                    }
                }
            }
            return productsToReturn;
        }

        public void RemoveProductById(int id)
        {
            int index = Products.FindIndex(x => x.Id == id);
            Products.RemoveAt(index);

        }
        public void RemoveProductByTitle(string productName)
        {
            int index = Products.FindIndex(x => x.Title == productName);
            Products.RemoveAt(index);
        }

        public void DiscountAllProducts(int percent)
        {
            foreach (var product in Products)
            {
                double NewPrice = product.Price * percent / 100;
                NewPrice = product.Price - NewPrice;

                product.Price = NewPrice;

            }
        }
        public void UpdateProductPrice(int productId, double newPrice)
        {
            foreach (var product in Products)
            {
                if (product.Id == productId)
                {
                    product.Price = newPrice;
                }
            }
        }


    }

}
