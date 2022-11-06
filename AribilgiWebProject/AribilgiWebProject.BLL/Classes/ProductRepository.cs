using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AribilgiWebProject.BLL.Classes
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public BaseResponseModel<List<Product>> GetCategoryProducts(int CategoryId)
        {
            BaseResponseModel<List<Product>> responseModel = new BaseResponseModel<List<Product>>();
            try
            {
                responseModel.ResponseModel =
                UnitOfWork.GetAll<Product>().Where(_ => _.CategoryId == CategoryId).ToList();
                responseModel.ResponseMessage = "Successfull";
            }
            catch (Exception ex)
            {
                responseModel.ErrorMessage= ex.Message;
                responseModel.IsSuccess = false;
            }
            return responseModel;
        }
    }
}
