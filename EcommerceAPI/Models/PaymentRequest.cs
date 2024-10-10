namespace EcommerceAPI.Models
{
    public class PaymentRequest
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // e.g., "credit card", "paypal"
        public string PaymentToken { get; set; } // Token from payment gateway
    }
}
