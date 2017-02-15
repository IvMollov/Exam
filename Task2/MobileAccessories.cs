using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public class MobileAccessories
    {
        private Dictionary<string, decimal> catalogueAccessories;
       

        public Dictionary<string, decimal> CatalogueAccessories { get; set; }


        public string Tittle { get; set; }
        public decimal PricePhone  
        {
            get
            {
                return this.PricePhone;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price should be possitive!");
                }
                this.PricePhone = value;
            }
        }
        public MobileAccessories(string title, decimal price)
        {
            this.Tittle = title;
            this.PricePhone = price;
        }

    }
}
