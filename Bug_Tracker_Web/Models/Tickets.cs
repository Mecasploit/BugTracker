using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bug_Tracker_Web.Models
{
    public class Tickets
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Issue { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
        //[Required]
        public string Owner { get; set; } = "def";
        [Required]
        public string? Assignee { get; set; }
        public DateTime Resolved { get; set; }
        [Required]
        public string? Status { get; set; }
        public string? Attachments { get; set; }
        public string? Comments { get; set; }
        [ForeignKey("ProjectId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; } = 1;
    }
}
