using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface ICommonRepository
    {
        BaseResponseModel<List<City>> GetCityList();
        BaseResponseModel<List<District>> GetDistrictList(int CityId);
    }
}
