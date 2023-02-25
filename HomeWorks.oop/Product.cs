using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class Product
    {
        public int Id
        {
            get;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Keywords { get; set; } = new List<string>();

        public Product()
        {
            Id = 0;
            Title = "";
            Description = "";
            Price = 0;

        }

        public Product(int id, string title, string description, double price, List<string> keywords)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            Keywords = keywords;
        }

        public string GetAsText()
        {
            string StringToReturn = "";
            string KeyWrordsString = "";
            Keywords.ForEach(word => { KeyWrordsString += word + "\n"; });
            StringToReturn = $"Id:{Id} \nTitle:{Title} \nDescription:{Description} \nPrice:{Price} \nKeyWords:{KeyWrordsString} \n";
            return StringToReturn;
        }

        public string GetAsTextShort()
        {
            string StringToReturn = "";
            StringToReturn = $"Id:{Id} \nTitle:{Title} \nDescription:{Description} \nPrice:{Price} \n";
            return StringToReturn;
        }

        public string GetAllKeywordsAsTextSeperated(char seperatedChar)
        {
            string StringToReturn = "";
            string KeyWrordsString = "";
            Keywords.ForEach(word => { KeyWrordsString += word + seperatedChar; });
            KeyWrordsString.TrimEnd(seperatedChar);
            StringToReturn = $"KeyWords:{KeyWrordsString}";
            return StringToReturn;
        }

        public void AddKeywords(string[] keywordstoAdd)
        {
            foreach (string keyword in keywordstoAdd)
            {
                Keywords.Add(keyword);
            }
        }

        public double Discount(int percentDiscount)
        {
            double NewPrice = Price * percentDiscount / 100;
            NewPrice = Price - NewPrice;
            return NewPrice;
        }
    }
}
