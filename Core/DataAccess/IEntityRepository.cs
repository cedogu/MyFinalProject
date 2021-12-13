using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic Constraint
    //class= ref type   
    //IEntity or a class that is implemented by IEntity
    //it should be written with new()
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //Entities- Concrete içindeki Product'ı listele dediğimizde Entity'deki Product'u kendine referans alır ve yukarı Entities.Concrete ekler
        T Get(Expression<Func<T, bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
