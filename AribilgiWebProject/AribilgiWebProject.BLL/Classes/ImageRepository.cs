using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AribilgiWebProject.BLL.Classes
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public BaseResponseModel<List<Image>> ProductImages(int ProductId)
        {
            var response = new BaseResponseModel<List<Image>>();
            try
            {
                response.ResponseModel = UnitOfWork.Instance.GetAll<Image>()
                                .Where(x => x.TableReferance == ProductId 
                                      && x.TableName == "Product")
                                .ToList();
            }
            catch (System.Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }
            return response;

        }
    }
}
