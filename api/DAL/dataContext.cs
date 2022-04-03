using api.DAL.data;
using Microsoft.EntityFrameworkCore;

namespace api.DAL
{

    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<hospital> Hospitals { get; set; }
        public DbSet<Cardio> Cardios { get; set; }
        public DbSet<Brief> Briefs { get; set; }
         
       
    }

}