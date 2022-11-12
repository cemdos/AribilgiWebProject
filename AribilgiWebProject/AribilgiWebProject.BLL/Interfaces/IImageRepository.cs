using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System.Collections.Generic;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface IImageRepository:IBaseRepository<Image>
    {
        BaseResponseModel<List<Image>> ProductImages(int ProductId);
    }
}
