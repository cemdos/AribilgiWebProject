using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface ICouponRepository:IBaseRepository<Coupon>
    {
        BaseResponseModel<Coupon> NewCoupon();

        BaseResponseModel<Coupon> GetCoupon(string CouponCode);
    }
}
