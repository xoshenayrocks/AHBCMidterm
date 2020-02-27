using System;
namespace POSMidterm
{
    public class Product

    {
        public Product(string foodName, double price)
        {
            FoodName = foodName;
            Price = price;
        }

        public string FoodName { get; set; }
        public double Price { get; set; }

      
    }
}
