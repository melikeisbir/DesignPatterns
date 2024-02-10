using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;//sonraki onaylayıcı //kendi sınıfı ve bu sınıfı miras alan diğer sınıfların erişimi
        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor; //sıradaki çalışan diğer çalışandan gelen değer olacak
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req); //bu sınıftan bir istek parametresi oluştur
    }
}
