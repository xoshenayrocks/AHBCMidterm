using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace POSMidterm
{
    public class Streams
    {

        static string filePath = "../../../ale";
        static int linenumber = 1;
        static string orderedItem;
        static List<Product> wholeOrder = new List<Product>();

        // The list and such should be a list of Menu objects, and the price will be within that object. The price can be pulled through a loop.

        public static void ReadTheMenu(int linenumber)
        {
            using (StreamReader inputfile = new StreamReader(filePath))
            {
                for (int i = 1; i <= linenumber; i++)
                {
                    Console.WriteLine(inputfile.ReadLine());
                }
            }
        }

        public static string AddToOrder(int linenumber) //The item the user wants can be arranged to be on the same line
        {

            string orderedItem = "water"; // this should be the water option in the Menu Class, not just this string. Return type may change.

            using (StreamReader inputfile = new StreamReader(filePath))
            {
                for (int i = 1; i <= linenumber; i++)
                {
                    if (i == linenumber)
                    {
                        orderedItem = inputfile.ReadLine();

                    }
                }

                return orderedItem;
            }

        }

        public static List<Product> AddToOrderList(int linenumber)
        {

            Product orderPart = InstantiateObject(linenumber);
            Console.WriteLine($"How many {orderPart.FoodName}s do you want?");
            int qty = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qty; i++) //qty is Alejandra's variable for the user's quanity input; it doesn ot exist in this file as yet.
            {
              wholeOrder.Add(orderPart);
            }

            return wholeOrder;

        }

        public static void DisplayMenuToUser()
        {
            var lineCount = File.ReadLines("../../../ale2"); // Why is this still interpreted as a string?
            List<string> menuList = new List<string>(lineCount);
            var linenumber = menuList.Count;
            foreach (string item in menuList)
            {
                Console.WriteLine(item);
            }

        }

        public static Product InstantiateObject(int linenumber) 
        {
            string orderedItem = "";

            using (StreamReader inputfile = new StreamReader(filePath))
            {
                for (int i = 1; i <= linenumber; i++)
                {
                    
                    
                    orderedItem = inputfile.ReadLine();
                    if (i == linenumber)
                    {
                        break;
                    }
                    
                }

                string[] orderedProduct = orderedItem.Split(".");

                Product foodItem = new Product(orderedProduct[0], Double.Parse(orderedProduct[1]));
                return foodItem;
            }

        }

        public static double InstatiateSubTotal()
        {
            double subTotal = SubtotalBill.SubTotalGetter(wholeOrder);
            return subTotal;
        }

        public static double InstatiateGrandTotal()
        {
            double grandTotal = SubtotalBill.SubTotalGetter(wholeOrder) * 1.06;
            return grandTotal;
        }

        public static string PrintOutOrder()
        {

          string foodName = default;
            double foodPrice = default;

            foreach (Product item in wholeOrder)
            {
                foodName = (item.FoodName);
                foodPrice = (item.Price);
                Console.WriteLine(($"You ordered {foodName} at a cost of ${foodPrice}"));
            }

            return "==========================";
        }

        public static int ValidateUserInput()
        {
            int usersChoice = default;
            bool keepItUp = true;
            while (keepItUp)
            {
                Console.WriteLine("Please enter the number of the menu item you wish to order.");
                var userInput = int.TryParse(Console.ReadLine(), out usersChoice);
                if (userInput == false)
                {
                    Console.WriteLine("Invalid selection.");
                    keepItUp = true;
                }
                else if (usersChoice == 1 || usersChoice == 2 || usersChoice == 3 || usersChoice == 4 || usersChoice == 5 || usersChoice == 6 || usersChoice == 7 || usersChoice == 8 || usersChoice == 9 || usersChoice == 10 || usersChoice == 11 || usersChoice == 12)
                {
                    keepItUp = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

            return usersChoice;
        }

        



    }

        // TryParse is an option. Split the string.
        // Instatiate a Menu/Product class object and assign the parameters from the array created from the .Split() above.

        /*public static void WriteTheMenu(string filePath)
{
    using (StreamWriter inputfile = new StreamWriter(filePath))
    {
        inputfile.WriteLine("rain rain go away");
    }
}

public static void AppendTheMenu()
{
    using (StreamWriter inputfile = new StreamWriter(filePath, true))
    {
        inputfile.WriteLine("cool");
    }*/


}

    

