using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SongsAPI.Models;

namespace SongsAPI.Data
{
    public class SongsDbContext(DbContextOptions<SongsDbContext> options):DbContext(options)
    {

        public DbSet<Songs> Songs => Set<Songs>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Songs>().HasData(

                    new Songs { Id = 1, Name = "Torna a casa", Singer = "Damiano David", Genre = "Italian pop" },
                    new Songs { Id = 2, Name = "Bad Blood", Singer = "Taylor Swift", Genre = "Pop" },
                    new Songs { Id = 3, Name = "The show must go on", Singer = "Fredy Mercury with Queen",Genre="Classic" },
                    new Songs { Id = 4, Name = "Prince Igor",Singer="Natasha Morozova",Genre="Russian folk" },
                    new Songs { Id = 5, Name = "Next Summer",Singer="Damiano David",Genre="Italian pop"}


            );
                
                

        }

    }
}
