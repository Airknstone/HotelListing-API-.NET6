using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    //This step is necessary due to the connection string we defined in prgram.cs
    public class HotelListingDbContext : DbContext //dbcontext base class comes from entity frameworkcore

    //db context is our contract that lets the app know about database tables
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) // dbcontextoptions type is comming from the options we defined in the conn string
        {

        }

        // The two databases we have created, create am entity class and register it to the db context
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        //open package manager console and enter add-migration InitialMigration to build db file
        //after file generation is complete enter update-database to complete write.

        //Seeding a database
        //override and onmodelcreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configure how data you want to go in
            modelBuilder.Entity<Country>().HasData(//accepts an array of objects
                new Country // new object with key values
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                  new Country
                  {
                      Id = 2,
                      Name = "Bahamas",
                      ShortName = "BS"
                  }
                  ,
                     new Country
                     {
                         Id = 3,
                         Name = "Cayman Island",
                         ShortName = "CI"
                     }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                Id        = 2,
                Name      = "Comfort Suites",
                Address   = "Geroge Town",
                CountryId = 3,
                Rating    = 4.3
                },
                new Hotel
                {
                Id        = 3,
                Name      = "Grand Palldium",
                Address   = "Nassua",
                CountryId = 2,
                Rating    = 4
                }
                );
            //After definine seeding enter Add-Migration "migration-name" to make changes to DB
        }
    }
}
