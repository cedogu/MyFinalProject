using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Mathematic mathematic = new Mathematic();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("The developer of the future is coming");


            MyDelegate3 myDelegate3 = mathematic.Sum;
            myDelegate3 += mathematic.Multiple;
            var result= myDelegate3(5, 6);
            Console.WriteLine(result);
            Console.ReadLine();

            //int döndürenlerde delegeye en son neyi verirsek onu calıstırır. yukarıda en son Multiple vermişiz, o calıstı
        }
    }

    //delege ile cagrılan methodun tipleri aynı olmalı. void ise void string ise string
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Delegates");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Alert");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Mathematic
    {
        public int Sum(int nr1, int nr2)
        {
            return nr1 + nr2;
        }
        public int Multiple(int nr1, int nr2)
        {
            return nr1 * nr2;
        }
    }
}
