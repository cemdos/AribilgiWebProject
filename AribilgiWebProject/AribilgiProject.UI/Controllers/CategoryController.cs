using AribilgiProject.UI.ViewModel;
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
            var BllData = categoryRepository.GetAll();
            if (!BllData.IsSuccess)
                return JsonDataConvert(BllData);

            BllData.ResponseModel = BllData.ResponseModel.OrderBy(_ => _.Name).ToList();
            BaseResponseModel<List<CategoryViewModel>> responseData = new BaseResponseModel<List<CategoryViewModel>>();
            responseData.ResponseModel = new List<CategoryViewModel>();
            foreach (var item in BllData.ResponseModel)
            {
                CategoryViewModel viewModelItem = new CategoryViewModel(item);
                responseData.ResponseModel.Add(viewModelItem);
            }
            return JsonDataConvert(responseData);
        }
    }
}