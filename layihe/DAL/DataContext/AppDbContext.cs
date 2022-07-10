using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Fly> Flies { get; set; }
        public DbSet<PilotGalery> PilotGaleries { get; set; }
        public DbSet<ArrivalCity> ArrivalCities { get; set; }
        public DbSet<DepartureCity> DepartureCities { get; set; }
    }
}
