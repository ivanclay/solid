using System;
using System.IO;
using System.Net.Mail;

namespace SRP_Priciple_Violation
{
    class Order
    {
        public long Quantity { get; set; }
        public DateTime Date { get; set; }
        public void AddOrder()
        {
            try
            {
                // Add order code
                // Send email code
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendEmailOrder(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\projetos\ErrorLog.txt", ex.ToString());
            }
        }
        public void RemoveOrder()
        {
            try
            {
                //Codigo para deletar o pedido gerado
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendEmailOrder(MailMessage mailMessage)
        {
            try
            {
                // TODO send email code 
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
