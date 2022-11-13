using AribilgiProject.UI.ViewModel;
using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public class CouponController : BaseController
    {
        private CouponRepository couponRepository;
        public CouponController()
        {
            couponRepository = new CouponRepository();
        }

        [HttpGet]
        public string GetCheckCoupon()
        {
            var CouponCode = Request.Params["CouponCode"];

            var result = couponRepository.GetCoupon(CouponCode);
            return JsonDataConvert(result);
        }
    }
}