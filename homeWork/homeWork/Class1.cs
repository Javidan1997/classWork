using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork
{
    public class Medicine
    {
        public string Name;
        public double Price;
        private int _count;
        public int Count
        {
            get { return this._count; }
            set
            {
                if (value > 0)
                    this._count = value;
                else Console.WriteLine("Say 0-dan boyuk olmalidir");
            }
            
        }
                
                     
        public Medicine(string name, double price)
        {
            this.Name = name;
            if (price > 0)
                this.Price = price;
            else Console.WriteLine("Qiymet 0-dan kicik ola bilmez");

        }

    }
}
