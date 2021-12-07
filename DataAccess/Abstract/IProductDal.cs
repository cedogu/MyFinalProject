using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();  //Entities- Concrete içindeki Product'ı listele dediğimizde Entity'deki Product'u kendine referans alır ve yukarı Entities.Concrete ekler
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


        List<Product> GetAllByCategory( int categoryId);
    }
}
