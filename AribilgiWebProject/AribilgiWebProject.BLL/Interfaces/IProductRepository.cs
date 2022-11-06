using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        BaseResponseModel<List<Product>> GetCategoryProducts(int CategoryId);
    }
}
