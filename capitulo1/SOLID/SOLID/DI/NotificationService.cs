using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DI
{

    //clase  de alto nivel no dependa de una clase de bajo nivel
    public interface INotificaction 
    {
        void Send();
    }
    public class Email : INotificaction
    {
        public string Sender { get; set; }
        public string Message { get; set; }
        public string To { get; set; }

        public void Send()
        {
            Console.WriteLine("Send Notification");
        }
    }


    public class NotificationService
    {
        public void SendNotification(INotificaction notification) 
        {
            notification.Send();
        }
    }
}
