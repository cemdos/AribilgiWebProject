using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public class CategoryController : BaseController
    {
        private CategoryRepository categoryRepository;
        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        [HttpGet]
        public string GetAllCategory()
        {
            var resultData = categoryRepository.GetAll();
            if (resultData.IsSuccess)
                resultData.ResponseModel = 
                    resultData.ResponseModel.OrderBy(_ => _.Name).ToList();
            return JsonDataConvert(resultData);
        }
    }
}