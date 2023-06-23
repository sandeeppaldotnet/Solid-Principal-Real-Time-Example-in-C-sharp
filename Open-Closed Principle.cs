using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_Real_Time_Example_in_C_sharp
{
    internal class Open_Closed_Principle
    {
        public class Invoice
        {
            public virtual double GetInvoiceDiscount(double amount)
            {
                return amount - 10;
            }
        }
        public class FinalAmount:Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 20;
            }
        }
        public class FridayDiscountAmount:Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount)-30;
            }
        }
        public class WeeklyDiscountAmount : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 40;
            }
        }

    }

