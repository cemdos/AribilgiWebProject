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
#if !DEBUG
    [Authorize]
#endif
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
        [HttpGet]
        [Route("api/Category/AddCategory/{Name}/{Icon}/{Description}/{ParentId}")]
        public BaseResponseModel<Category> AddCategory(string Name,string Icon,string Description, int ParentId)
        {
            try
            {
                var categoryModel = new Category
                {
                    Name = Name,
                    Icon = Icon,
                    Description = Description,
                    ParentId = ParentId
                };
                var result = categoryRepository.Add(categoryModel);
                return result;
            }
            catch (Exception ex)
            {
                return new BaseResponseModel<Category>
                {
                    ErrorMessage = ex.Message,
                    ResponseCode = Common.Enums.ResponseCode.ValidationErrors,
                    IsSuccess = false
                };
            }

        }

    }
}
