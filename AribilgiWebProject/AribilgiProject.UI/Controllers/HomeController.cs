using AribilgiWebProject.BLL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public class HomeController : Controller
    {
        private ProductRepository productRepository;
        public HomeController()
        {
            productRepository = new ProductRepository();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product(int id)
        {
            ViewBag.PageName = "Product Pages";
            var resultData = productRepository.GetCategoryProducts(id);
            return View(resultData);
        }
    }
}