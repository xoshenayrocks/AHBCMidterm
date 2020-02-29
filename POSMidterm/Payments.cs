﻿using System;
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
<<<<<<< HEAD
            Console.WriteLine("How would you like to pay for your item(s)? [1] Cash, [2] Credit, or [3] Check?");
            string userInput = Console.ReadLine();
            if (userInput == "1" ||userInput.Equals("cash", StringComparison.OrdinalIgnoreCase))
            {
                decimal change = (decimal)SubtotalBill.GetChange(GetCashPayment(), SubtotalBill.GetActualTotal(1, 2));
                Console.WriteLine($"Change due: ${change} ");
                //"GetActualTotal" method needs to take in price of product and qty
=======
            Console.WriteLine("How would you like to pay for your items? [1] Cash, [2] Credit, or [3] Check?");
            string userInput = Console.ReadLine();
            if (userInput == "1" ||userInput.Equals("cash", StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine($"Change due: ${SubtotalBill.GetChange(GetCashPayment(), SubtotalBill.GetActualTotal(1, 2))} "); 
                Console.WriteLine("Thank you! Enjoy!");
                //need to add get change method from Alejandra
>>>>>>> 4c7ee0b58bb46325ac92255264bbe75582c2aa70
            }
            else if (userInput == "2" || userInput.Equals("credit", StringComparison.OrdinalIgnoreCase))
            {
                ValidateCreditCardInfo();
            }
            else if (userInput == "3" || userInput.Equals("check", StringComparison.OrdinalIgnoreCase))
            {
<<<<<<< HEAD
                GetCheckNumber();
=======

>>>>>>> 4c7ee0b58bb46325ac92255264bbe75582c2aa70
            }

        }

        public static double GetCashPayment()
        {
            Console.WriteLine("Please enter cash amount tendered: ");
            string userInput = Console.ReadLine();
            double amountTendered = double.Parse(userInput);
<<<<<<< HEAD
            Console.WriteLine("Thank you! Enjoy!");
=======
>>>>>>> 4c7ee0b58bb46325ac92255264bbe75582c2aa70
            return amountTendered;
        }

        public static void GetCheckNumber()
        {
            Regex checkNumber = new Regex(@"^([0-9]){4}$");
<<<<<<< HEAD
            Console.WriteLine("Please enter the check number: ");
            string userCheckNumber = Console.ReadLine();
            bool isValid = true;

            do
            {
                if (!checkNumber.IsMatch(userCheckNumber))
                {
                    Console.WriteLine("Check number is invalid. Please enter a valid 4-digit check number.");
                    userCheckNumber = Console.ReadLine();
                    isValid = false;
                }
            } while (!isValid);

            Console.WriteLine("Thank you! Enjoy!");

=======
            Console.WriteLine("Please enter the check number: " );
            string userCheckNumber = Console.ReadLine();
            if (!checkNumber.IsMatch(userCheckNumber))
            {

            }
>>>>>>> 4c7ee0b58bb46325ac92255264bbe75582c2aa70
        }

        public static void ValidateCreditCardInfo()
        {

            Regex creditCard = new Regex(@"(([0-9]){4}){4}");
            Regex expiration = new Regex(@"^(0[1-9]|1[0-2])\/([0-9]){2}");
            Regex cvv = new Regex(@"^([0-9]){3}$");

            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter your credit card number, expiration date [MM/YY], and 3-digit CVV number: ");
          
                string userInput = Console.ReadLine();
                string[] creditCardInfo = userInput.Split(" ");

                if (!creditCard.IsMatch(creditCardInfo[0]))
                {
                    Console.WriteLine("Card number is not valid. Please enter a valid 16-digit card number.");
                    creditCardInfo[0] = Console.ReadLine();
                    isValid = false;
                }
                if (!expiration.IsMatch(creditCardInfo[1]))
                {
                    Console.WriteLine("Expiration date is not valid. Please enter a valid 2-digit month and 2-digit year.");
                    creditCardInfo[1] = Console.ReadLine();
                    isValid = false;
                }

                if (!cvv.IsMatch(creditCardInfo[2]))
                {
                    Console.WriteLine("CVV is not valid. Please enter the 3-digit CVV number on the back of your card.");
                    creditCardInfo[2] = Console.ReadLine();
                    isValid = false;
                }
                else if (creditCard.IsMatch(creditCardInfo[0]) || expiration.IsMatch(creditCardInfo[1]) || cvv.IsMatch(creditCardInfo[2]))
                {
<<<<<<< HEAD
                    Console.WriteLine("Thank you! Enjoy!");
=======
                    Console.WriteLine("Thank you!");
>>>>>>> 4c7ee0b58bb46325ac92255264bbe75582c2aa70

                }
            } while (isValid);


        }

<<<<<<< HEAD

=======
>>>>>>> 4c7ee0b58bb46325ac92255264bbe75582c2aa70
    }
}
