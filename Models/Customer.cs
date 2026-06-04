using System.ComponentModel.DataAnnotations;

namespace CustomerEngagementPlatform.Models
{
    // Stores customer information
    public class Customer
    {
        // Primary Key
        public int CustomerId { get; set; }

        // Customer full name
        [Required(ErrorMessage = "Customer name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        // Email used for communication
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Contact number of customer
        [Required]
        public string Phone { get; set; }

        // Optional customer address
        public string? Address { get; set; }

        // One customer can raise multiple tickets
        public ICollection<Ticket>? Tickets { get; set; }
    }
}