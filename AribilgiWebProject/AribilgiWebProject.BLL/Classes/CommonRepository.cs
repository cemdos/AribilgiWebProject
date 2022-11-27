using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AribilgiWebProject.BLL.Classes
{
    public class CommonRepository : ICommonRepository
    {
        public BaseResponseModel<List<City>> GetCityList()
        {
            var response = new BaseResponseModel<List<City>>();
            try
            {
                response.ResponseModel = UnitOfWork.Instance.GetAll<City>();
            }
            catch (System.Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }

        public BaseResponseModel<List<District>> GetDistrictList(int CityId)
        {
            var response = new BaseResponseModel<List<District>>();
            try
            {
                response.ResponseModel = UnitOfWork.Instance.GetAll<District>()
                                                   .Where(x=>x.CityId==CityId)
                                                   .ToList();
            }
            catch (System.Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
