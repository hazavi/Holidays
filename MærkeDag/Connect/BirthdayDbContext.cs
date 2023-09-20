using Microsoft.EntityFrameworkCore;

namespace MærkeDag.Data
{

    public class BirthdayDbContext : DbContext
    {
        public BirthdayDbContext(DbContextOptions<BirthdayDbContext> options)
            : base(options)
        {
        }

        public DbSet<Birthday> Birthdays { get; set; }
    }

}
