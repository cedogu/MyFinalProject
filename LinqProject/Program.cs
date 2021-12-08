using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
               new Category { CategoryId = 1, CategoryName = "Computer" },
               new Category { CategoryId = 2, CategoryName = "Telephone" }
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=25 },
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=8000, UnitInStock=60 },
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=7000, UnitInStock=20 },
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung", QuantityPerUnit="16 GB RAM", UnitPrice=5000, UnitInStock=59 },
                new Product{ProductId=5, CategoryId=2, ProductName="Apple", QuantityPerUnit="128 GB RAM", UnitPrice=6500, UnitInStock=0 }

            };

            //Test(products);

            //GetProducts(products);
            //any her zaman BOOL döner -- true ya da false
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDestTest(products);
            // ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId=p.ProductId, CategoryName=c.CategoryName, ProductName=p.ProductName, UnitPrice=p.UnitPrice};

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} ---- {1}"   , productDto.ProductName, productDto.CategoryName);
            }

            Console.ReadLine();







        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();
        }

        private static void AscDestTest(List<Product> products)
        { //Single line query!
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 4);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            var result1 = products.Any(p => p.ProductName == "Dell Laptop");
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }

        private static void Test(List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }


            Console.WriteLine("Linq--------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

            foreach (var product1 in result)
            {
                Console.WriteLine(product1.ProductName);
            }
        }

        //static List<Product> GetProducts(List<Product> products)
        //{
        //    List<Product> filteredProducts = new List<Product>();

        //   
        //    return filteredProducts;
        //}

        //Usage of Linq
        static List<Product> GetProductsLing(List<Product> products)
        {
           return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();    
        }

        class ProductDto // dto means *** data transformation object
        {
            public int ProductId { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
        }   


        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }

            public string ProductName { get; set; }

            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitInStock { get; set; }
        }


        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }


    }
}

