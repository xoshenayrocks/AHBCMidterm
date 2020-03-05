using System;
using System.Collections.Generic;

namespace POSMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> wholeOrder = default;
            UserInterface.GreetUser();
            Streams.DisplayMenuToUser();

            bool keepGoing = true;

            while (keepGoing)
            {
                UserInterface.AskForOrder();
                wholeOrder = Streams.AddToOrderList(int.Parse(Console.ReadLine()));
                Console.WriteLine("Would you like to order anything else? (y/n)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "n")
                {
                    keepGoing = false;
                }
            }

            
            Console.WriteLine($"Your subtotal is {Payments.PrintDollar((SubtotalBill.SubTotalGetter(wholeOrder)))}");
            Console.WriteLine($"Your grand total is {Payments.PrintDollar((SubtotalBill.GrandTotalGetter(wholeOrder)))}");
            Payments.GetPaymentType();
            Receipt.DisplayReceipt();
        }
    }
}
