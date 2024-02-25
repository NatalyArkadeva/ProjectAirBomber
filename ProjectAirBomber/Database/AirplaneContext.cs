using Microsoft.EntityFrameworkCore;
using ProjectAirBomber.CollectionGenericObjects;
using ProjectAirBomber.Drawnings;
using ProjectAirBomber.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Database
{
    public class AirplaneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=projectairbomber;Username=postgres;Password=admin");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<EntityAirplane> Airplanes { set; get; }
        public virtual DbSet<EntityAirBomber> AirBombers { set; get; }
        public virtual DbSet<CollectionInfo> Collections { set; get; }
    }
}
