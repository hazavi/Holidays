using Microsoft.EntityFrameworkCore;

namespace MærkeDag.Data
{
    public class HolidayDbContext : DbContext
    {       
            public HolidayDbContext(DbContextOptions<HolidayDbContext> options)
                : base(options)
                {

                }

        public DbSet<Holiday> Holiday { get; set; }
    }

    
}
