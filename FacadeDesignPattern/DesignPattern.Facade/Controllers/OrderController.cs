using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderStart(int customerID, int productId, int orderID, int productCount, decimal productPrice)
        {
            OrderFacade order = new OrderFacade();
            order.CompleteOrder(customerID, productId, orderID, productCount, productPrice);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
