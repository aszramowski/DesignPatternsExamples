using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class NotifyBaseDecorator : INotify
    {
        private INotify component;

        public NotifyBaseDecorator(INotify component)
        {
            this.component = component;
        }

        public virtual void Notify(string message)
        {
            component.Notify(message);
        }
    }
    public class NotifySmsDecorator : NotifyBaseDecorator
    {        
        public NotifySmsDecorator(INotify component) : base(component)
        {            
        }
        public override void Notify(string message)
        {
            base.Notify(message);
            NotifySms(message);
        }
        public void NotifySms(string message)
        {
            Console.WriteLine("Wysyłam dodatkowe powiadomienie sms: " + message);
        }
    }
    public class NotifyFacebookDecorator : NotifyBaseDecorator
    {
        public NotifyFacebookDecorator(INotify component) : base(component)
        {

        }
        public override void Notify(string message)
        {
            base.Notify(message);
            NotifyFacebook(message);
        }

        public void NotifyFacebook(string message)
        {
            Console.WriteLine("Wysyłam dodatkowe powiadomienie facebook: " + message);
        }
    }
}
