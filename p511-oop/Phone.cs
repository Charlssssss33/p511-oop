using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Phone
    {
        private string brand;
        private string moddel;
        private int price;



        public Phone(string brand, string model, int price)
        {
            this.brand = brand;
            this.moddel = model;
            this.price = price;
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                this.brand = value;
            }
        }
        public string Model
        {
            get
            {
                return moddel;
            }
            set
            {
                moddel = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
       
        
          

       
        
    }
}
