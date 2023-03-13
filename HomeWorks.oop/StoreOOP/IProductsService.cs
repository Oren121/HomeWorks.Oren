using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.StoreOOP
{
    public interface IProductsService
    {
        public void AddNewCategory(string categoryName, int categoryParentId);
        public void AddNewProduct(string name, decimal price, bool isinstock, int categoryId);
        public void AddNewProducts(Product[] products, int categoryId);
        public void RemoveProduct(string productId);
        public void UpdateProduct(string productId, Product newProductInfo);
        public List<Category> GetAllTopLevelCategories();
        public List<Category> GetSubCategories(int parentCategoryID);
        public List<Product> GetProductsCategory(int categoryId);
        public List<Product> GetAllProductsByPrice(int lowPrice, int highPrice);
        public List<Product> GetAllProductsByPrice(int inCategoryId, int lowPrice, int highPrice);
        public List<Product> GetAllProducts();
        public Product FindProductByName(string productname);
        public void RemoveAllProductsOfCategory(int categoryId);
        public void SaveAllProductsByCategory(int categoryId); //file name will be the according to the value of of the Category Name property 	

    }
}
