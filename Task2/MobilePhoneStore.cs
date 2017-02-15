using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public class MobilePhoneStore
    {
        public ICollection<MobilePhones> Phones { get; set; }
        public ICollection<MobileAccessories> Accessories { get; set; }

        public void AddPhone(string vendor, string model, decimal price)
        {
            MobilePhones phones = new MobilePhones(vendor, model, price);
            if(Phones.ContainsKey(List<M>)
            {
                Console.WriteLine("Duplicate phone");
            }
            else
            {
                Phones.Add(phones);
                Console.WriteLine("Phone added");
            }
        }
        public void AddAccessory(string title, decimal price)
        {
            MobileAccessories accessories = new MobileAccessories(title, price)
            if (accessories(title))
            {
                Console.WriteLine("Duplicate accessory");
            }
            else
            {
                catalogueAccessories.Add(title, price);
                Console.WriteLine("Accessory added");
            }
        }
        public void PrintAccessory()
        {
            if (catalogueAccessories.Count == 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                foreach (var item in catalogueAccessories)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
