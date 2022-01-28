using Microsoft.EntityFrameworkCore;
using NASA_API.Domain.Models;

namespace NASA_API.Domain.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rover> Rovers { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Rover>().HasData(
                new Rover {
                    Id = 1,
                    Name = "Curiosity",
                    NasaUrl = "https://www.nasa.gov/",
                    Description = "Ett fordon som letar liv på Mars.",
                    History = "Ett rymdfordon för att utforska möjligheten kring tidigare liv på planeten Mars" +
                    " 26 November 2011 och landade på Mars 5 augusti 2012 på vid kratern Gale." +
                    " Fordonet var vid tillfället det tyngsta och mest komplexa fordonet NASA skickat till Mars." +
                    " Curiosity är utrustat med instrumet för att genomföra teste för att undersöka eventuellt liv på planeten.",
                    Weight = 900, // Kilo,
                    NumberOfWheels = 6
                },
                new Rover
                {
                    Id = 2,
                    Name = "Spirit",
                    NasaUrl = "https://www.nasa.gov/",
                    Description = "NASAs första rymdfordon i Mars-utforskningsprogrammet \"Mars Exploration Rover Mission\"",
                    History = "Spirit sköts upp den 10 juni 2003 och landade på Mars yta den 3 januari 2004." +
                    " Spirit var planerad att överleva 90 dagar på Mars men klarade sig 2 269 dagar",
                    Weight = 180, // Kilo
                    NumberOfWheels = 6
                },
                new Rover
                {
                    Id = 3,
                    Name = "Opportunity",
                    NasaUrl = "https://www.nasa.gov/",
                    Description = "NASAs andra rymdfordon i Mars-utforskningsprogrammet \"Mars Exploration Rover Mission\"",
                    History = "Oppotunity sköts upp 8 juli 2003 och landade sedan på planeten Mars den 25 januari 2004." +
                              " NASAs målsättning var att Opportunity skulle fungera 90 dagar på planeten, men fordonet överlevde 15 år." +
                              " Dess huvuduppdrag var att utforska eventuell förekomst av vatten på planetens yta." +
                              " Rymdfordonet Spirit är Opportunitys tvilling.",
                    Weight = 180, // Kilo
                    NumberOfWheels = 6
                }
            );
        }
    }
}
