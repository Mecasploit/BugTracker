using Bug_Tracker_Web.Models;
using Microsoft.EntityFrameworkCore;

// code first aproach : create code -> Db will be created automatically 

namespace Bug_Tracker_Web.Data
{
    public class ApplicationDbContext:DbContext //enherate frome entity freamwork core 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) //ctor and double tab. 
        {
        }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Projects> Projects { get; set; }
    }
}
