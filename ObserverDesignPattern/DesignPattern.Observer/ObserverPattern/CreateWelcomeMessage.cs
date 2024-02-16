using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser) ///yeni kullanıcı oluşturulduğunda tetiklenecek metot
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + "" + appUser.Surname,
                Content="Dergi bültenimize kayıt olduğunuz için teşekkürler. Dergilerimize web sitemizden ulaşabilirsiniz."
            });
            context.SaveChanges();
        }
    }
}
