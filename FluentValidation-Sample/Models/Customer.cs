namespace FluentValidation_Sample.Models
{
    public class Customer
    {
        public string? FirstName { get; set; } 

        public string? LastName { get; set; } 

        public string? Email { get; set; } 

        public int? Age { get; set; }

        public Address Address { get; set; } = new();
    }
}
