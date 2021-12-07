using System;
using System.Collections.Generic;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> { new Category { CategoryId = 1, CategoryName = "Computer" },
            new Category { CategoryId = 2, CategoryName = "Telephone" }
        };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=1000, UnitInStock=25 },
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=9000, UnitInStock=60 },
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=3000, UnitInStock=20 },
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung", QuantityPerUnit="16 GB RAM", UnitPrice=500, UnitInStock=59 },
                new Product{ProductId=5, CategoryId=2, ProductName="Apple", QuantityPerUnit="128 GB RAM", UnitPrice=1000, UnitInStock=0 }
            };
            

            Console.WriteLine("Hello World!");
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
