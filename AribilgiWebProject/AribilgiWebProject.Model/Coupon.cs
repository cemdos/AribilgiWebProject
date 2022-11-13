namespace AribilgiWebProject.Model
{
    public class Coupon:BaseModel
    {
        public string CouponCode { get; set; }
        public byte DiscountPercent { get; set; }
        public int AvailableCount { get; set; }
        public int UsedCount { get; set; }
    }
}
