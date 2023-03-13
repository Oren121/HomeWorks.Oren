using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorks.oop.StoreOOP
{
    public class Category
    {
        private static int _Id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCatogoryId { get; set; }

        public Category(string name, int parentCatogoryId)
        {
            _Id++;
            Id = _Id;
            Name = name;
            ParentCatogoryId = parentCatogoryId;
        }

        public Category(string name)
        {
            _Id++;
            Id = _Id;
            Name = name;
            ParentCatogoryId = 0;
        }

        public Category()
        {
            _Id++;
            Id = _Id;
            Name = "";
            ParentCatogoryId = 0;
        }
        public override string ToString()
        {
            string StringToReturn = $"ID:{Id} \n" +
                $"Name:{Name}\n" +
                $"Parent Catogory Id:{ParentCatogoryId}\n";
            return StringToReturn + base.ToString();
        }
    }
}
