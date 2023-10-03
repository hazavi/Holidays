using Microsoft.EntityFrameworkCore;

namespace MærkeDag.Data
{

    public class HolidayDbContext : DbContext
    {
        public HolidayDbContext(DbContextOptions<HolidayDbContext> options)
            : base(options)
        {
        }

        public DbSet<Birth> Birthdays { get; set; }
        public DbSet<Holiday> Holidays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Holiday>().HasData(
                new Holiday
                {
                    ID = 1,
                    Date = new DateTime(2023, 1, 1),
                    Name = "Nytårsdag"
                },
                new Holiday
                {
                    ID = 2,
                    Date = new DateTime(2023, 4, 6),
                    Name = "Skærtorsdag"
                },
                new Holiday
                {
                    ID = 3,
                    Date = new DateTime(2023, 4, 7),
                    Name = "Langfredag"
                },
                new Holiday
                {
                    ID = 4,
                    Date = new DateTime(2023, 4, 9),
                    Name = "Påskedag"
                },
                new Holiday
                {
                    ID = 5,
                    Date = new DateTime(2023, 4, 10),
                    Name = "2. Påskedag"
                },
                new Holiday
                {
                    ID = 6,
                    Date = new DateTime(2023, 5, 5),
                    Name = "Store bededag"
                },
                new Holiday
                {
                    ID = 7,
                    Date = new DateTime(2023, 5, 18),
                    Name = "Kristi Himmelfartsdag"
                },
                new Holiday
                {
                    ID = 8,
                    Date = new DateTime(2023, 5, 19),
                    Name = "Banklukkedag"
                },
                new Holiday
                {
                    ID = 9,
                    Date = new DateTime(2023, 5, 28),
                    Name = "Pinsedag"
                },
                new Holiday
                {
                    ID = 10,
                    Date = new DateTime(2023, 5, 29),
                    Name = "2. Pinsedag"
                },
                new Holiday
                {
                    ID = 11,
                    Date = new DateTime(2023, 6, 5),
                    Name = "Grundlovsdag"
                },
                new Holiday
                {
                    ID = 12,
                    Date = new DateTime(2023, 12, 24),
                    Name = "Juleaftensdag"
                },
                new Holiday
                {
                    ID = 13,
                    Date = new DateTime(2023, 12, 25),
                    Name = "Juledag / 1. juledag"
                },
                new Holiday
                {
                    ID = 14,
                    Date = new DateTime(2023, 12, 26),
                    Name = "2. juledag"
                },
                new Holiday
                {
                    ID = 15,
                    Date = new DateTime(2023, 12, 31),
                    Name = "Nytårsaftensdag"
                }
            );
        }


    }

}
