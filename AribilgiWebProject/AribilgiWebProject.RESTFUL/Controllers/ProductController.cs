using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using AribilgiWebProject.RESTFUL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace AribilgiWebProject.RESTFUL.Controllers
{
#if !DEBUG
    [Authorize]
#endif
    public class ProductController : ApiController
    {
        private ProductRepository productRepository;
        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        [HttpGet]
        public BaseResponseModel<List<Product>> GetAllProduct()
        {
            var BllData = productRepository.GetAll();
            BllData.ResponseModel = BllData.ResponseModel.Select(x => 
                new Product { Name = x.Name, 
                              Description = x.Description,
                              Stock = x.Stock,
                              UnitPrice = x.UnitPrice,
                              Discount = x.Discount,
                              Rate = x.Rate}).ToList();
            return BllData;
        }

        [HttpGet]
        [Route("api/Product/AddProduct/{Name}/{Stock}/{UnitPrice}/{Discount}/{Rate}/{Description}")]
        public BaseResponseModel<Product> AddProduct(string Name, int Stock, double UnitPrice, short Discount,short Rate, string Description)
        {
            try
            {
                var productModel = new Product
                {
                    Name = Name,
                    Description = Description,
                    Rate = Rate,
                    Stock = Stock,
                    UnitPrice = UnitPrice,
                    Discount = Discount
                };
                var result = productRepository.Add(productModel);
                result.ResponseModel = new Product
                {
                    Name = result.ResponseModel.Name,
                    Description = result.ResponseModel.Description,
                    Stock = result.ResponseModel.Stock,
                    UnitPrice = result.ResponseModel.UnitPrice,
                    Discount = result.ResponseModel.Discount,
                    Rate = result.ResponseModel.Rate
                };
                return result;
            }
            catch (Exception ex)
            {
                return new BaseResponseModel<Product>
                {
                    ErrorMessage = ex.Message,
                    ResponseCode = Common.Enums.ResponseCode.ValidationErrors,
                    IsSuccess = false
                };
            }

        }

    }
}
