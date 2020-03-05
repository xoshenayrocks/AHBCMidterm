using System;
namespace POSMidterm
{
    public class Receipt
    {
        public Receipt()
        {
         
        }


        public static void DisplayReceipt()
        {
            var dateTime = DateTime.Now;
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("         RECEIPT     ");
            Console.WriteLine("==========================");
            Console.WriteLine($"{dateTime}");
            Console.WriteLine("");
            Console.WriteLine($"{Streams.PrintOutOrder()}");
            Console.WriteLine($"Subtotal: {Payments.PrintDollar(Streams.InstatiateSubTotal())}");
            Console.WriteLine($"Total tax: {Payments.PrintDollar(SubtotalBill.TotalTax())}");
            Console.WriteLine($"Grand total: {Payments.PrintDollar((Streams.InstatiateGrandTotal()))}");
            Console.WriteLine("");
            Console.WriteLine($"Payment type: {Payments.PaymentType}");
            Console.WriteLine($"Amount tendered: {Payments.PrintDollar(Payments.AmountTendered)}");
           Console.WriteLine($"Change due: {Payments.PrintDollar(Payments.Change)}");
            Console.WriteLine("==========================");
            Console.WriteLine("Thank you! Please come again!");


        }
    }
}
