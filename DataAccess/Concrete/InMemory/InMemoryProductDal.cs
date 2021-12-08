using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal :IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
             new Product{ProductId=1, CategoryId=1, ProductName="Glass", UnitPrice=15, UnitsInStock=150},
             new Product{ProductId=2, CategoryId=1, ProductName="Camera", UnitPrice=500, UnitsInStock=15},
             new Product{ProductId=3, CategoryId=2, ProductName="Cell Phone", UnitPrice=750, UnitsInStock=100},
             new Product{ProductId=4, CategoryId=2, ProductName="Keyboard", UnitPrice=20, UnitsInStock=65},
             new Product{ProductId=5, CategoryId=2, ProductName="Mouse", UnitPrice=10, UnitsInStock=21},        
            
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ = language integrated query
            //Lambda

            //foreach (var p in _products)
            //{
            //    if (product.ProductId==product.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

     
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == p.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            

        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
