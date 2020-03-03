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

            double changeTotal = amountTendered- actualTotal;
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


        //below, what i think is happening is that there is a

        
    }

}

   