using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Hotel> HotelS { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id= 1,
                    Name = "Eritrea",
                    ShortName = "ERI"
                }, new Country
                {
                    Id= 2,
                    Name = "Ethiopia",
                    ShortName = "ETH"
                }, new Country
                {
                    Id = 3,
                    Name = "Sweden",
                    ShortName = "SWE"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id= 1,
                    Name = "Gedam Hotel",
                    Address = "Massawa",
                    CountryId= 1,
                    Rating= 5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Bole",
                    Address = "Addis",
                    CountryId = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Euro Stop",
                    Address = "Jönköping",
                    CountryId = 3,
                    Rating = 5
                }
                );
        }

    }
}
