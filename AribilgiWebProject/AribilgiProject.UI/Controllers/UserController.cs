using AribilgiProject.UI.ViewModel;
using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public class UserController : BaseController
    {
        private UserRepository userRepository;
        public UserController()
        {
            userRepository = new UserRepository();
        }

        public string RegisterUser()
        {
            var Username = Request.Params["UserName"];
            var Email = Request.Params["Email"];
            var Password = Request.Params["Password"];

            var response = userRepository.Register(Username, Email, Password);
            return JsonDataConvert(response);
        }

        public string LoginUser()
        {
            var Username = Request.Params["UserName"];
            var Password = Request.Params["Password"];

            var response = userRepository.Login(Username, Password);
            return JsonDataConvert(response);
        }

        public string SaveAddress()
        {
            var UserId = int.Parse(Request.Params["UserId"]);
            var InvoiceAddress = Request.Params["InvoiceAddress"];
            var ShippedAddress = Request.Params["ShippedAddress"];

            var response = userRepository.SaveAdress(UserId, InvoiceAddress, ShippedAddress);
            return JsonDataConvert(response);
        }

    }
}