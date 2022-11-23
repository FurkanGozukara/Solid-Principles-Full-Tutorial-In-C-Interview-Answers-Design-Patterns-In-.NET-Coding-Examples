using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_design_principles
{
    internal class ProperOpenClosed
    {
        public class Invoice
        {
            public virtual double GetInvoiceDiscount(double amount)
            {
                return amount - 10;
            }
        }

        public class FinalInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 90;
            }
        }
        public class ProposedInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 40;
            }
        }
        public class RecurringInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 65;
            }
        }

        public class SuperInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 5;
            }
        }
    }
}
