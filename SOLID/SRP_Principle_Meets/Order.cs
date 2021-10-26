using System;

namespace SRP_Principle_Meets
{
    class Order
    {
        public long Quantity { get; set; }
        public DateTime Date { get; set; }
        private Ilogger infoLogger;
        private SendEmail sendEmail;
        public Order()
        {
            sendEmail = new SendEmail();
            infoLogger = new RegisterLog();
        }
        public void AddOrder()
        {
            try
            {
                infoLogger.Info("Add an Order");
                sendEmail.EMailFrom = "emailfrom@xyz.com";
                sendEmail.EMailTo = "emailto@xyz.com";
                sendEmail.EMailSubject = "SRP";
                sendEmail.EMailBody = "Order";
                sendEmail.Send();
            }
            catch (Exception ex)
            {
                infoLogger.Info("Error to send email : " + ex.Message);
            }
        }
        public void RemoveOrder()
        {
            try
            {
                //Codigo para deletar o pedido gerado
                infoLogger.Info("Order removed at " + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro to remove order " + ex.Message);
            }
        }
    }
}
