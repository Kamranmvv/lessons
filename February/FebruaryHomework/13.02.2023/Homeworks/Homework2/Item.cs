using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Item
    {
        public string Make;
        public string Model;
        public int Year;
        public int Km;
        public string Fuel;
        public string Gearbox;
        public int PurchasePrice;
        public int SellingPrice;
        public int MaxDiscount;
        public int Price;
        public Item(string make, string model)
        {
           
        }
        public Item(string make, string model, int year)
        {

        }
        public Item(string make, string model, int year, int km)
        {

        }
        public Item(string make, string model, int year, int km,string fuel , string gearBox , int purchasePrice, int sellingPrice , int maxDiscount, int price)
        {
            Make = make;
            Model = model;
            Year = year;
            Km = km;
            Fuel = fuel;
            Gearbox = gearBox;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            MaxDiscount = maxDiscount;
            Price = price;
        }
        public void MinPrice(int sellingPrice, int maxDiscount, int price)
        {

            int minPrice = sellingPrice - maxDiscount;
            if (maxDiscount > sellingPrice)
            {
                Console.WriteLine("Max discount can't be greater than selling price!");
                
            }
            else
            {
                if (price < minPrice)
                {
                    Console.WriteLine("You tried to set a price lower than the max discount price!");
                   
                }
            }
            
        }
        public void AllInformation()
        {
            Console.WriteLine("Make: {0} \nModel: {1} \nYear: {2} \nKM: {3} \nFuel: {4} \nGearBox: {5} \nPurchase Price: {6} \nSelling Price: {7} \nMax Discount: {8} \nPrice: {9}", Make, Model, Year, Km, Fuel, Gearbox, PurchasePrice, SellingPrice, MaxDiscount, Price);
        }
        
       
    }
}
