using System;
using System.Collections.Generic;
using System.Text;

namespace Practika_Aptek
{
    internal class Phramacy
    {
        public string Name;
        public static int Id = 0;
        public Drug[] Arr;
        public Phramacy()
        {
            Id++;
            Arr = new Drug[0];
        }
        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}";
        }
        public Drug[] AddDrug(Drug drug)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = drug;
            return Arr;
        }
        public void DrugList()
        {
            foreach (Drug item in Arr)
            {
                Console.WriteLine($"Drug name: {item.Name}, Drug count: {item.Count}, Drug price: {item.Price}");
            }

        }
        public  void SealDrug(string name, int count, double price)
        {
            bool names = false;
            bool counts = false;
            bool prices = false;
            foreach (Drug item in Arr)
            {
                if (item.Name == name)
                {
                    names = true;
                }
                if (item.Count >= count)
                {
                    counts = true;
                }
                if (item.Price <= price)
                {
                    prices = true;
                }
                bool Temp = names && counts && prices;
                if (Temp == true)
                {
                    Console.WriteLine("Derman satila biler");
                     int  tempCount = item.Count - count;
                    double TotalPrice =0;
                    TotalPrice += item.Price;
                    
                    Console.WriteLine("Count: "+tempCount);
                    Console.WriteLine($"Totalincome: {TotalPrice}");
                }
                

            }
        }
    }
}
