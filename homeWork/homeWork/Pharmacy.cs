using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork
{
    public class Pharmacy : Medicine
    {
        public Pharmacy(string name, double price) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
        }

        private string[] _medicines;
        public string [] Medicines
        { get { return this._medicines; }

            set
            { 

            }               
        }

            
        private double _totalIncome;
        public double TotalIncome
        {
            get { return this._totalIncome; }
            
        }



        public void Sell(string Medicines, double priceOfMedicine )
        {
            this.Count--;
            this._totalIncome+=priceOfMedicine;
        }
        public void FindMedicineByName(string nameOfMedicine)
        {
            

        }
    }
}
