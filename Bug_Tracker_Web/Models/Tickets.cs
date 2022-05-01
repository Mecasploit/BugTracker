using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bug_Tracker_Web.Models
{
    public class Tickets
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Issue { get; set; }
        public string Priority { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
        [Required]
        public string Owner { get; set; }
        [Required]
        public string? Assignee { get; set; }
        public DateTime Resolved { get; set; }
        [Required]
        public string? Status { get; set; }
        public string? Attachments { get; set; }
        public string? Comments { get; set; }
        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }
    }
}
