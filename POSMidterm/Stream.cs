using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace POSMidterm
{
    public class Streams
    {

        static string filePath = "C:/Users/Sipe/AHBC-DOTNET-Q1-2020-Det/FileIO/bin/Debug/netcoreapp3.1/ale";
        static int linenumber = 6;
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

        public static void AddToOrderList(int linenumber)
        {
            Product orderPart = InstantiateObject(linenumber); // Menu class does not exist in this file.

            wholeOrder.Add(orderPart);
        }

        public static void DisplayMenuToUser()
        {
            var lineCount = File.ReadLines(@"C:/Users/Sipe/AHBC-DOTNET-Q1-2020-Det/FileIO/bin/Debug/netcoreapp3.1/ale"); // Why is this still interpreted as a string?
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
    }


}*/
    }
}

