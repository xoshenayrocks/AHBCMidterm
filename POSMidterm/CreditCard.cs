using System;
using System.Text.RegularExpressions;

namespace POSMidterm
{
    public class CreditCard
    {
        public static string ExpirationDate { get; set; }
        public static string CardNumber { get; set; }
        public static string CVV { get; set; }

        public CreditCard(string cardNumber, string exp,  string cvv)
        {
            ExpirationDate = exp;
            CardNumber = cardNumber;
            CVV = cvv;
        }


        public static void ValidateCreditCardInfo()
        {

            Regex validCreditCard = new Regex(@"(([0-9]){4}){4}");
            Regex validExpiration = new Regex(@"^(0[1-9]|1[0-2])\/([0-9]){2}");
            Regex validCvv = new Regex(@"^([0-9]){3}$");

            string cardNumber = UserInterface.GetUserInput("Please enter your 16-digit credit card number :");
            while ((UserInterface.ValidatePaymentInput(cardNumber, validCreditCard) == false))
                {
                cardNumber = UserInterface.GetUserInput("Card number is not valid. Please enter a valid 16-digit card number.");
                UserInterface.ValidatePaymentInput(cardNumber, validCreditCard);
            }

            string exp = UserInterface.GetUserInput("Please enter your expiration date[MM / YY]: ");
            while((UserInterface.ValidatePaymentInput(exp, validExpiration) == false))
            {
                exp = UserInterface.GetUserInput("Expiration date is not valid. Please enter a valid 2-digit month [MM] and 2-digit year [YY] expiration date: ");
            }
             string cvv = UserInterface.GetUserInput("Please enter your 3-digit CVV number: ");
            while((UserInterface.ValidatePaymentInput(cvv, validCvv) == false))
            {
                cvv = UserInterface.GetUserInput("CVV is not valid. Please enter a valid 3-digit CVV number.");
            }

            CreditCard clientCard = new CreditCard(cardNumber, exp, cvv);
         
        }
   
    }
}
