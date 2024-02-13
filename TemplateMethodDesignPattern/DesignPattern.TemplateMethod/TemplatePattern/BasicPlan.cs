using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public class BasicPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content; //bunların değeri controller tarafında kullanıcıya bırakıldı
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson; //basic planda kişi sayısı sabit de olabilirdi
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
