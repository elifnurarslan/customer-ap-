namespace customer.Models
{
    public class Customer
    {
         public int ID { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string MobilPhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
