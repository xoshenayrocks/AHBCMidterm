using System;
using System.Collections.Generic;

namespace POSMidterm

{
    public static class SubtotalBill
    {

        public static double GetSubTotal(double cost, double qty)
        {
            double total = cost * qty;
            return total;
        }

        public static double GetGrandTotal(double cost, double qty)
        {
            double actualTotal = GetSubTotal(cost, qty) * 1.06;
            return actualTotal;
        }

        public static double GetChange(double amountTendered, double actualTotal)
        {
            
            while (amountTendered < actualTotal)
            {
                Console.WriteLine($"Whoops! Looks like you are short {Payments.PrintDollar((actualTotal-amountTendered))}. Please enter additional funds to cover your bill.");
                double additionalFunds = double.Parse(Console.ReadLine());
                amountTendered += additionalFunds;
            }
            double changeTotal = amountTendered - actualTotal;
            return changeTotal;
        }

        public static double SubTotalGetter(List<Product> wholeOrder)
        {
            double subtotal = 0;
          foreach (Product item in wholeOrder)
            {
                subtotal += item.Price;
            }

            return subtotal;
        }

        public static double GrandTotalGetter(List<Product> wholeOrder)
        {
            double grandTotal = (SubTotalGetter(wholeOrder)) * 1.06;
            return grandTotal;
        }

        public static double TotalTax()
        {
          double  subtotal = Streams.InstatiateSubTotal();
           double totaltax = subtotal *.06;
            return totaltax;
        }


        //below, what i think is happening is that there is a

        
    }

}

   