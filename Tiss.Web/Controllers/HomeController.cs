using System.Threading;
using System.Web.Mvc;
using Tiss.Data.Contracts;

namespace Tiss.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository ProductRepository { get; set; }

        public HomeController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            if (Request.IsAjaxRequest())
            {
                var products = ProductRepository.GetAll();

                return View(products);
            };

            return RedirectToAction("Index");
        }
    }
}