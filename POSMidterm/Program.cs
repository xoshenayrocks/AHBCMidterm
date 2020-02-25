using System;

namespace POSMidterm
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu water = new Menu("Water", 1.75);
            Menu punch = new Menu("Berry Rum Punch", 12);
            Menu lasagna = new Menu("Veggie Lasagna", 15);
            Menu curry = new Menu("Jackfruit Curry", 13);
            Menu mangoSmoothie = new Menu("Mango Smoothie", 3.50);
            Menu mintJulip = new Menu("Mint Julip", 5);
            Menu tomatoSoup = new Menu("Tomato Soup", 7);
            Menu chowder = new Menu("Clam Chowder", 7);
            Menu marrow = new Menu("Roasted Bone Marrow", 13);
            Menu spaghetti = new Menu("Spaghetti Carbonara", 15);
            Menu mimosa = new Menu("Mimosa", 7);
            Menu johnnyWalker = new Menu("Johnny Walker Black", 12);

            Console.WriteLine($"{water.FoodName} - ${water.Price}");
        }
    }
}
