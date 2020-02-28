using System;
using System.Text.RegularExpressions;

namespace POSMidterm
{
    public class Payments
    {
        public Payments()
        {
        }

        public static void GetPaymentType ()
        {
            Console.WriteLine("How would you like to pay for your items? [1] Cash, [2] Credit, or [3] Check?");
            string userInput = Console.ReadLine();
            if (userInput == "1" ||userInput.Equals("cash", StringComparison.OrdinalIgnoreCase))
            {
                GetCashPayment();
                Console.WriteLine("Thank you! Enjoy!");
                //need to add get change method from Alejandra
            }
            else if (userInput == "2" || userInput.Equals("credit", StringComparison.OrdinalIgnoreCase))
            {
                ValidateCreditCardInfo();
            }
            else if (userInput == "3" || userInput.Equals("check", StringComparison.OrdinalIgnoreCase))
            {

            }

        }
        public class CreditCard
        {

        }

        public static double GetCashPayment()
        {
            Console.WriteLine("Please enter the amount tendered");
            string userInput = Console.ReadLine();
            double amountTendered = double.Parse(userInput);
            return amountTendered;
        }

        public static void ValidateCreditCardInfo()
        {

            Regex creditCard = new Regex(@"(([0-9]){4}){4}");
            Regex expiration = new Regex(@"^(0[1-9]|1[0-2])\/([0-9]){2}");
            Regex cvv = new Regex(@"^([0-9]){3}$");

            bool isValid = false;
          
            while (!isValid)
            {
                Console.WriteLine("Please enter your credit card number, expiration date [MM/YY], and 3-digit CVV number. (Please enter one space between each.)");
                string userInput = Console.ReadLine();
                string[] creditCardInfo = userInput.Split(" ");

                if (!creditCard.IsMatch(creditCardInfo[0]))
                {
                    Console.WriteLine("Card number is not valid. Please enter a valid 16-digit card number.");
                    isValid = false;
                }
                if (!expiration.IsMatch(creditCardInfo[1]))
                {
                    Console.WriteLine("Expiration date is not valid. Please enter a valid 2-digit month and 2-digit year.");
                    isValid = false;
                }

                if (!cvv.IsMatch(creditCardInfo[2]))
                {
                    Console.WriteLine("CVV is not valid. Please enter the 3-digit CVV number on the back of your card.");
                }
                else
                {
                    Console.WriteLine("Thank you");
                    isValid = true;
                }
            }

        }

    }
}
