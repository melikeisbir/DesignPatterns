using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = _customerService.TGetByID(model.SenderID);
            var value2 = _customerService.TGetByID(model.ReceiverID);

            value1.CustomerBalance -= model.Amount; //gönderici olduğumuz için -= olacak modelden gelen amount tutarını balancedan düş
            value2.CustomerBalance += model.Amount; //modelden gelen amountı balanceın ustune ekle

            List<Customer> modifiedCustomer = new List<Customer>() //güncellennmiş customer listesini tutacak
            {
                value1,
                value2
            };

            _customerService.TMultiUpdate(modifiedCustomer);

            return View();
        }
    }
}
