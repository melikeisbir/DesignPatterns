using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier //default olarak bildirim oluştursun
    {
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        virtual public void CreateNotify(Notifier notifier) // içinde context sınıfı oldugu için bir daha tanımlamadık
        {//virtual anahtar kelimesini ekleyerek bunun içeriğinin başka yerlerde değiştirilebilecğini uygulamaya belirtildi
            notifier.NotifierCreator = "Admin";
            notifier.NotifierSubject = "Toplantı";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}
