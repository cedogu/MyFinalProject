using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Gürsoy", Age = 26 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {

        public int Id { get; set; }
        [RequiredProperty]   //-- ilgili nesne için kural oluşturduk. // calısılan nesnelere anlam katmak için attribute kullanırız.
        public string FirstName { get; set; }
        [RequiredProperty]     //Attribute'lara parametre de yollanır.
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, please use AddNew")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}, added! ", customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}, added! ", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property)] //-- sadece nesneleri kapsar cünkü nesnelerle calısıyoruz
    class RequiredPropertyAttribute:Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute //-- sadece classları kapsar
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
