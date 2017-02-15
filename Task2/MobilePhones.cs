using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public class MobilePhones 
    {

        public string Vendor { get; set; }
        public string Model { get; set; }
        public decimal Price
        {
            get
            {
               return this.Price ;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("The price should be possitive!");
                }
                this.Price = value;
            }
        }
        public MobilePhones (string vendor, string model, decimal price)
        {
            this.Vendor = vendor;
            this.Model = model;
            this.Price = price;
        }


        public void AddPhone(string vendor, string model, decimal price)
        {
            if (catalogue.ContainsKey(new List<MobilePhones>() { new MobilePhones() { Vendor = vendor, Model = model } }))
            {
                Console.WriteLine("Duplicate phone");
            }
            else
            {
                catalogue.Add(new List<MobilePhones>() { new MobilePhones() { Vendor = vendor, Model = model } }, price);
                Console.WriteLine("Phone added");
            }            
        }

    }
}
