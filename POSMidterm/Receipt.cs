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
            Console.WriteLine("==========================");
            Console.WriteLine("         RECEIPT     ");
            Console.WriteLine("==========================");
            Console.WriteLine($"{dateTime}");
            Console.WriteLine("");
            Console.WriteLine($"{Streams.PrintOutOrder()}");
            Console.WriteLine($"Subtotal: ${Streams.InstatiateSubTotal()}");
            Console.WriteLine($"Grand Total: ${Streams.InstatiateGrandTotal()}");
            //need to put if client pays with cash, credit, card
           
        }
    }
}
