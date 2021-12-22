using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisc = new Product(50);
            harddisc.ProductName = "Hard Disc";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisc.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();

        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish");
        }
    }
}
