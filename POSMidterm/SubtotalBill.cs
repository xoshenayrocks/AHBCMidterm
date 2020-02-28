using System;
using System.Collections.Generic;

namespace POSMidterm

{
    public static class SubtotalBill
    {

        public static double GetTotal(double cost, double qty)
        {
            double total = cost * qty;
            return total;
        }

        public static double GetActualTotal(double cost, double qty)
        {
            double actualTotal = GetTotal(cost, qty) * 1.06;
            return actualTotal;
        }

        public static double GetChange(double amountTendered, double actualTotal)
        {
            double changeTotal = amountTendered- actualTotal;
            return changeTotal;
        }




        //below, what i think is happening is that there is a

        
    }

}

   