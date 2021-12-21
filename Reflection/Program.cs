using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //FourOperations fourOperations = new FourOperations(3, 5);
            //Console.WriteLine(fourOperations.Multiple2());
            //Console.WriteLine(fourOperations.Multiple(3, 4));


            var type = typeof(FourOperations);
            FourOperations fourOperations=(FourOperations)Activator.CreateInstance(type, 5,6); //-- fouroperations fouroperations = new fouroperations(); SAME
            //Console.WriteLine(fourOperations.Sum(4, 5)); //reflection ile instance olusturunca onun metodunu da calıstırıyorsunuz.
            //Console.WriteLine(fourOperations.Sum2());

            var instance = Activator.CreateInstance(type, 5, 6);

            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("-------");
            var methods = type.GetMethods();
            foreach (var info in methods)
            {
                Console.WriteLine("Method name: {0} ", info.Name);
                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine("Parameters: {0} ", parameter.Name);
                }
            }
            Console.Read();

            //multiple deyince sayı istiyor ama multiple2 deyince sayı istemiyor cünkü üstünde verdigimiz değeri kullanır.
            //o değerleri de ctor ile biz aşağıda vermiştik!!!
        }
    }
    public class FourOperations
    {
        private int _n1;   //private verdigimiz değerleri ctor ile eşleştirince yukarıda metod icine değer vermesek de oluyor.
                           

        private int _n2;
        public FourOperations(int n1, int n2) //--- ctorrrrrrrrrrr
        {
            _n1 = n1;
            _n2 = n2;
        }
        public FourOperations()
        {

        }
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        
        public int Multiple(int n1, int n2)
        {
            return n1 * n2;
        }
        public int Sum2()
        {
            return _n1 + _n2;
        }
        public int Multiple2()
        {
            return _n1 * _n2;
        }
    }
}
