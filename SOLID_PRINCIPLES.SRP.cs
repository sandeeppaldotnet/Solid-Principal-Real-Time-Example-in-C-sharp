using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_Real_Time_Example_in_C_sharp
{

    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        private readonly ILogger logger;
        private readonly MailSender emailSender;
        public Invoice()
        {
            logger = new Logger();
			emailSender = new MailSender();

        }
        public void GenerateInovoice()
        {
            try
            {
                logger.Info("Add method Start");
				//Generate Invoice and Sent on mail
				emailSender.EMailFrom = "emailfrom@xyz.com";
				emailSender.EMailTo = "emailto@xyz.com";
				emailSender.EMailSubject = "Single Responsibility Princile";
				emailSender.EMailBody = "A class should have only one reason to change";
				emailSender.SendEmail();
			}
            catch (Exception ex)
            {
				logger.Error("Error Occurred while Generating Invoice", ex);
			}
        }
		public void DeleteInvoice()
		{
			try
			{
				// Code for Deleting the already generated invoice
				logger.Info("Delete Invoice Start at @" + DateTime.Now);
			}
			catch (Exception ex)
			{
				logger.Error("Error Occurred while Deleting Invoice", ex);
			}
		}
	}


   public interface ILogger
	{
		void Info(string message);
		void Warn(string message);
		void Error(string message,Exception ex);
	}
    class Logger : ILogger
    {
        public Logger()
        {
            
        }
        public void Error(string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
	public class MailSender
	{
		public string EMailFrom { get; set; }
		public string EMailTo { get; set; }
		public string EMailSubject { get; set; }
		public string EMailBody { get; set; }
		public void SendEmail()
		{
			// Here we need to write the Code for sending the mail
		}
	}
}
