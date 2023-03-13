using Demos.HackerU.HomeWorks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWorks.oop.StoreOOP
{
    internal class ProductsService : IProductsService
    {
        private static IProductsService instanceObj = null;
        private readonly List<Category> _categories;
        private readonly List<Product> _products;

        public static IProductsService GetInstance()
        {
            if (instanceObj == null)
            {
                instanceObj = new ProductsService();
            }
            return instanceObj;
        }
        public void AddNewCategory(string categoryName, int categoryParentId)
        {
            Category NewCategory = new Category(categoryName, categoryParentId);
            _categories.Add(NewCategory);
        }

        public void AddNewProduct(string name, decimal price, bool isinstock, int categoryId)
        {
            Product NewProduct = new Product(name, price, isinstock, categoryId.ToString());
            _products.Add(NewProduct);
        }

        public void AddNewProducts(Product[] products, int categoryId)
        {
            foreach (Product Product in products)
            {
                AddNewProduct(Product.Name, Product.Price, Product.Isinstock, categoryId);
            }
        }

        public Product FindProductByName(string productname)
        {
            Product? result = _products.Find(x => x.Name == productname);
            return result;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _products.ToList();
            return products;
        }

        public List<Product> GetAllProductsByPrice(int lowPrice, int highPrice)
        {
            List<Product> products = new List<Product>();
            foreach (Product Product in _products)
            {
                if (Product.Price >= lowPrice && Product.Price <= highPrice)
                {
                    products.Add(Product);
                }
            }
            return products;
        }

        public List<Product> GetAllProductsByPrice(int inCategoryId, int lowPrice, int highPrice)
        {
            List<Product> products = new List<Product>();
            foreach (Product Product in _products)
            {
                if (Product.CategoryId == inCategoryId.ToString())
                {

                    if (Product.Price >= lowPrice && Product.Price <= highPrice)
                    {
                        products.Add(Product);
                    }
                }
            }
            return products;
        }

        public List<Category> GetAllTopLevelCategories()
        {
            List<Category> categories = new List<Category>();
            foreach (Category Category in _categories)
            {
                if (Category.ParentCatogoryId == 0)
                {
                    categories.Add(Category);
                }
            }
            return categories;
        }

        public List<Product> GetProductsCategory(int categoryId)
        {
            List<Product> products = new List<Product>();
            foreach (Product product in _products)
            {
                if (product.CategoryId == categoryId.ToString())
                {
                    products.Add(product);
                }
            }
            return products;
        }

        public List<Category> GetSubCategories(int parentCategoryID)
        {
            List<Category> categories = new List<Category>();
            foreach (Category Category in _categories)
            {
                if (Category.ParentCatogoryId == parentCategoryID)
                {
                    categories.Add(Category);
                }
            }
            return categories;
        }

        public void RemoveAllProductsOfCategory(int categoryId)
        {
            foreach (Product product in _products)
            {
                if (product.CategoryId == categoryId.ToString())
                {
                    _products.Remove(product);
                }
            }
        }

        public void RemoveProduct(string productId)
        {
            Product? result = _products.Find(x => x.Id == productId);
            if (result != null)
            {
                _products.Remove(result);
            }

        }

        public void SaveAllProductsByCategory(int categoryId)
        {
            foreach (Product product in _products)
            {
                File.AppendAllText($"category{categoryId}.txt", product.ToString() + "\n");
            }
        }

        public void UpdateProduct(string productId, Product newProductInfo)
        {
            Product? result = _products.Find(x => x.Id == productId);
            if (result != null)
            {
                result = newProductInfo;
            }
        }
    }
}
