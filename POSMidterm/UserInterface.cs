using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace POSMidterm
{
    class UserInterface
    {
        public static void GreetUser()
        {
            Console.WriteLine("Welcome to The Vine!");
            Console.WriteLine("Please take a look at our menu!");
            Console.WriteLine("");
        }

        public static void AskForOrder()
        {
            Console.WriteLine("");
            Console.WriteLine("What would you like to order? Please enter the corresponding menu number.");
        }


        public static string GetUserInput(string prompt)
        {
            string userInput = "";
            Console.WriteLine($"{prompt}");
            userInput = Console.ReadLine();

            return userInput;
        }
        public static bool ValidatePaymentInput(string input, Regex regex)
        {
            if (regex.IsMatch(input))
            { return true; }
            else
            {
                return false;
            }
        }
    }
}
