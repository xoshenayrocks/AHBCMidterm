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
            Console.WriteLine("Items Ordered: (this is where product and qty will go)");
            Console.WriteLine($"Subtotal: ${SubtotalBill.GetTotal(1,2)}");
            Console.WriteLine($"Grand Total: ${SubtotalBill.GetActualTotal(1,2)}");
            //need to put if client pays with cash, credit, card
           
        }
    }
}
