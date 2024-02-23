using DesignPattern.Composite.CompositePattern;
using DesignPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x => x.Products).ToList(); //categorynin içine productları dahil et
            var values = Rekursive(categories, new Category { CategoryName = "FirstCategory", CategoryID = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v = values;
            return View();
        }
        public ProductComposite Rekursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null) //yaprak kısmı son kısım
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList().ForEach(y => // bu kategorinin her biri için
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);

                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName)); //yeni bir product component ekle
                });

                if (leaf != null)
                {
                    leaf.Add(productComposite); //yaprak farklı olduğunda aşağıya doğru eklemeye devam et
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
