using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AribilgiProject.UI.ViewModel
{
    public class CouponViewModel : BaseViewModel<Coupon>
    {
        public string CouponCode { get; set; }
        public byte DiscountPercent { get; set; }
        public int AvailableCount { get; set; }
        public int UsedCount { get; set; }
        public bool IsApply => AvailableCount - UsedCount > 0;

        public CouponViewModel(Coupon coupon) : base(coupon)
        {
            CouponCode = coupon.CouponCode;
            DiscountPercent = coupon.DiscountPercent;
            AvailableCount = coupon.AvailableCount;
            UsedCount = coupon.UsedCount;
        }
    }
}