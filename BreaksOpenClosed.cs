using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_design_principles
{
    internal class BreaksOpenClosed
    {
        public class Invoice
        {
            public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
            {
                double finalAmount = 0;
                if (invoiceType == InvoiceType.FinalInvoice)
                {
                    finalAmount = amount - 100;
                }
                else if (invoiceType == InvoiceType.ProposedInvoice)
                {
                    finalAmount = amount - 50;
                }
                else
                    if (invoiceType == InvoiceType.RecurringInvoice)
                {
                    finalAmount = amount - 75;
                }
                return finalAmount;
            }
        }
        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice,
            RecurringInvoice
        };
    }
}
