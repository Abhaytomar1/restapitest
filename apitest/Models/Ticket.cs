using System;
using System.ComponentModel.DataAnnotations;

namespace TicketAPI.Models
{
    // Ticket model which have all fields of ticket
    public class Ticket
    {
        [Key]
        public int Id { get; set; }   // primary key

        [Required]
        public string TicketNo { get; set; }  // ticket number

        [Required]
        public string Subject { get; set; }

        [Required]
        public string TicketBody { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
