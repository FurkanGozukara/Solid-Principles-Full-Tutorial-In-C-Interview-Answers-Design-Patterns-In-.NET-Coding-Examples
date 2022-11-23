using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace solid_design_principles
{
    internal class SingleResponsibilityViolation
    {
        public class Invoice
        {
            public long InvAmount { get; set; }
            public DateTime InvDate { get; set; }
            //this method actually doing 3 seperate things
            public void AddInvoice()
            {
                try
                {
                    // Here we need to write the Code for adding invoice
                    // Once the Invoice has been added, then send the  mail
                    MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                    this.SendInvoiceEmail(mailMessage);
                }
                catch (Exception ex)
                {
                    //Error Logging
                    System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
                }
            }
            public void DeleteInvoice()
            {
                try
                {
                    //Here we need to write the Code for Deleting the already generated invoice
                }
                catch (Exception ex)
                {
                    //Error Logging
                    System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
                }
            }
            public void SendInvoiceEmail(MailMessage mailMessage)
            {
                try
                {
                    // Here we need to write the Code for Email setting and sending the invoice mail
                }
                catch (Exception ex)
                {
                    //Error Logging
                    System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
                }
            }
        }


    }
}
