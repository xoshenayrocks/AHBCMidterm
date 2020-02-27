using System;
namespace POSMidterm
{
    public class Menu
    {
        public Menu(string foodName, double price)
        {
            FoodName = foodName;
            Price = price;
        }

        public string FoodName { get; set; }
        public double Price { get; set; }

       
    }
}
