namespace WebApplication1.Models
{
    public class Realtor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Commission { get; set; }
    }

    public class Seller
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Buyer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Status { get; set; }
        public int SellerId { get; set; }
        public int RealtorId { get; set; }
        public Seller Seller { get; set; }
        public Realtor Realtor { get; set; }
    }
}
