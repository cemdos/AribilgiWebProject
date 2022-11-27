using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace AribilgiWebProject.BLL.Classes
{
    public class CouponRepository : BaseRepository<Coupon>, ICouponRepository
    {
        public BaseResponseModel<Coupon> GetCoupon(string CouponCode)
        {
            var response = new BaseResponseModel<Coupon>();
            try
            {
                var result  = UnitOfWork.Instance.GetAll<Coupon>()
                                            .Find(x => x.CouponCode == CouponCode);
                if (result == null)
                    throw new System.Exception("Kupon bulunamadı");
                else if (result.AvailableCount <= result.UsedCount)
                    throw new System.Exception("Kupon Kodu Daha önceden kullandı");

                response.ResponseModel = result;
            }
            catch (System.Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public BaseResponseModel<Coupon> NewCoupon()
        {
            var response = new BaseResponseModel<Coupon>();
            try
            {
                var couponCode = Guid.NewGuid().ToString().Substring(0, 5);
                response.ResponseModel = UnitOfWork.Instance.AddData(new Coupon
                {
                    CouponCode = couponCode,
                    AvailableCount = 3,
                    DiscountPercent = 50,
                    UsedCount = 0,
                });
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
