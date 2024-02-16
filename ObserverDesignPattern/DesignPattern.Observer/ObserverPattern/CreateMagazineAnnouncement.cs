using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {

        private readonly IServiceProvider serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + "" + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim dergilerimizin mart sayısı 1 Martta evinize ulaştırılacaktır. Konular Jupiter gezegeni ve Mars olacaktır."
            });
            context.SaveChanges();
        }
    }
}
