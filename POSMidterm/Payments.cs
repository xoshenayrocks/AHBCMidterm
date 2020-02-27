using System;
using System.Text.RegularExpressions;

namespace POSMidterm
{
    public class Payments
    {
        public Payments()
        {
        }

        public static void GetPaymentType (string userInput)
        {
            Console.WriteLine("How would you like to pay for your items? [1] Cash, [2] Credit, or [3] Check?");

            if (userInput == "1" ||userInput.Equals("cash", StringComparison.OrdinalIgnoreCase))
            {
                GetCashPayment(Console.ReadLine());
                Console.WriteLine("Thank you! Enjoy!");
                //need to add get change method
            }
            else if (userInput == "2" || userInput.Equals("credit", StringComparison.OrdinalIgnoreCase))
            {
                ValidateCreditCard(Console.ReadLine());
            }
            else if (userInput == "3" || userInput.Equals("check", StringComparison.OrdinalIgnoreCase))
            {

            }

        }
        public class CreditCard
        {

        }

        public static double GetCashPayment(string userInput)
        {
            Console.WriteLine("Please enter the amount tendered");
            double amountTendered = double.Parse(userInput);
            return amountTendered;
        }

        public static void ValidateCreditCard(string cardnumber)
        {

            Regex creditCard = new Regex(@"(([0-9]){4}){4}");
            bool isValid = false;
            while (isValid)
            {
                Console.WriteLine("Please enter your card number.");
                if (!creditCard.IsMatch(cardnumber))
                {
                    Console.WriteLine("Card number is not valid.");
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Thank you for your payment!");
                    isValid = true;
                }
            }

        }

    }
}
