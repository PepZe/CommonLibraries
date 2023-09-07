namespace CommonLibraries.Dto
{
    /// <summary>
    /// Coupon data transfer object.
    /// </summary>
    public class CouponDto
    {
        /// <summary>
        /// Coupon id.
        /// </summary>
        public int CouponId { get; set; }
        /// <summary>
        /// Coupon code.
        /// </summary>
        public string CouponCode { get; set; }
        /// <summary>
        /// Discount to be applied.
        /// </summary>
        public double DiscountAmount { get; set; }
        /// <summary>
        /// Min amount of the sales to be valid.
        /// </summary>
        public int MinAmount { get; set; }
    }
}
