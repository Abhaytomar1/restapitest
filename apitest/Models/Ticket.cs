using System;
using System.ComponentModel.DataAnnotations;

namespace TicketAPI.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TicketNo { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string TicketBody { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
