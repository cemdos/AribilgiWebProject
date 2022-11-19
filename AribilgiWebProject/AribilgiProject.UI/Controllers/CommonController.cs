using AribilgiProject.UI.ViewModel;
using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public class CommonController : BaseController
    {
        private CommonRepository commonRepository;
        public CommonController()
        {
            commonRepository = new CommonRepository();
        }

        [HttpGet]
        public string GetCityList()
        {
            var responseData = commonRepository.GetCityList();
            return JsonDataConvert(responseData);
        }

        [HttpGet]
        public string GetDistrictList()
        {
            var CityId = int.Parse(Request.Params["CityId"]);
            var responseData = commonRepository.GetDistrictList(CityId);
            return JsonDataConvert(responseData);
        }
    }
}