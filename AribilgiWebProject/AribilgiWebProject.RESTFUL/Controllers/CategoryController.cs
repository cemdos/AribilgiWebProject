using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using AribilgiWebProject.RESTFUL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AribilgiWebProject.RESTFUL.Controllers
{
    [Authorize]
    public class CategoryController : ApiController
    {
        private CategoryRepository categoryRepository;
        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        /// <summary>
        /// Tüm kategorilerin listesini ceken metotdur
        /// </summary>
        /// <returns>Getire BaseResponseModel tipinde bir liste döenecektir.</returns>
        [HttpGet]
        public BaseResponseModel<List<CategoryViewModel>> GetAllCategory()
        {
            var BllData = categoryRepository.GetAll();
            BllData.ResponseModel = BllData.ResponseModel.OrderBy(_ => _.Name).ToList();
            BaseResponseModel<List<CategoryViewModel>> responseData = new BaseResponseModel<List<CategoryViewModel>>();
            responseData.ResponseModel = new List<CategoryViewModel>();
            foreach (var item in BllData.ResponseModel)
            {
                CategoryViewModel viewModelItem = new CategoryViewModel(item);
                responseData.ResponseModel.Add(viewModelItem);
            }
            return responseData;
        }

    }
}
