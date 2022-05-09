using System.ComponentModel.DataAnnotations;


namespace Bug_Tracker_Web.Models
{
    public class Projects
    { 

        // Admines : have to be key 
        // Status
        // Testers

        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string? Name { get; set; }
        [Display(Name="Date of cration")]
        public DateTime DateOfCreation { get; set; }= DateTime.Now;
        public string? Description { get; set; }
        //public string? Status { get; set; }
        
    }
}
