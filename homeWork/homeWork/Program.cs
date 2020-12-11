using System;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy med = new Pharmacy("Zeferan", 2);
            med.Count = 10;

            med.Sell("Yod", 5);
            Console.WriteLine(med.TotalIncome);



        }
    }
}
