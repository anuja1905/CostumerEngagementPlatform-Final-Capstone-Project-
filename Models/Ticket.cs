using System.ComponentModel.DataAnnotations;

namespace CustomerEngagementPlatform.Models
{
    // Represents a service/support ticket
    public class Ticket
    {
        // Primary Key
        public int TicketId { get; set; }

        // Short title describing the issue
        [Required]
        public string Subject { get; set; }

        // Detailed explanation of the problem
        [Required]
        public string Description { get; set; }

        // Ticket status (Open, In Progress, Closed)
        public string Status { get; set; } = "Open";

        // Ticket priority (Low, Medium, High)
        public string Priority { get; set; } = "Medium";

        // Date when ticket was created
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Foreign Key linking ticket to customer
        public int? CustomerId { get; set; }

        // Navigation Property
        public Customer? Customer { get; set; }
    }
}
