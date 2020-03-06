using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace POSMidterm
{
    public class Payments
    {
        public static double Change { get; set; }
        public static double AmountTendered { get; set; }
        public static string PaymentType { get; set; }

        public Payments()
        {
            double change = 0;
            Change = change;
        }

        public static void GetPaymentType ()
        {
           
            Console.WriteLine("How would you like to pay for your item(s)? [1] Cash, [2] Credit, or [3] Check?");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "1":
                case "cash":
                    AmountTendered = GetCashPayment();
                   Change = SubtotalBill.GetChange(AmountTendered, Streams.InstatiateGrandTotal());
                    PaymentType = "Cash";
                    break;
                case "2":
                case "credit":
                    CreditCard.ValidateCreditCardInfo();
                    PaymentType = "Credit";
                    AmountTendered = Streams.InstatiateGrandTotal();
                    break;
                case "3":
                case "check":
                    GetCheckNumber();
                    PaymentType = "Check";
                    AmountTendered = Streams.InstatiateGrandTotal();
                    break;
                default:
                    Console.WriteLine( "Please enter a valid selection.");
                    GetPaymentType();
                    break;
            }

        }

        public static double GetCashPayment()
        { 
            string userInput = UserInterface.GetUserInput("Please enter cash amount tendered: ");
            double amountTendered = double.Parse(userInput);
            return amountTendered;
        }

       public static string PrintDollar(double amount)
        {
            string dollarAmount = amount.ToString("C", CultureInfo.CurrentCulture);
            return dollarAmount;
        }

        public static void GetCheckNumber()
        {
            Regex validCheckNumber = new Regex(@"^([0-9]){4}$");

          
            string checkNumber = UserInterface.GetUserInput("Please enter the check number: ");
            UserInterface.ValidatePaymentInput(checkNumber, validCheckNumber);
            while(UserInterface.ValidatePaymentInput(checkNumber, validCheckNumber) == false)
            {
                checkNumber = UserInterface.GetUserInput("Invalid check number. Please enter a valid 4-digit check number ");
            }
  
        }

    }
}
