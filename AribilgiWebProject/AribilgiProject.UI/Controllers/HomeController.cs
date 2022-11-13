using AribilgiProject.UI.ViewModel;
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
        private ImageRepository imageRepository;
        public HomeController()
        {
            productRepository = new ProductRepository();
            imageRepository = new ImageRepository();
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

            var responseViewModel = new BaseResponseModel<List<ProductViewModel>>();
            responseViewModel.ResponseModel = new List<ProductViewModel>();
            foreach (var item in resultData.ResponseModel)
            {
                var viewModel = new ProductViewModel(item);
                var imageResult = imageRepository.ProductImages(item.ID);
                if (!imageResult.IsSuccess)
                    return View(imageResult);
                viewModel.Images = imageResult.ResponseModel;
                responseViewModel.ResponseModel.Add(viewModel);
            }
            
            return View(responseViewModel);
        }

        public ActionResult Cart()
        {
            return View();
        }
    }
}