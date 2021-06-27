using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SportsEventsManagementSystem.Models
{
    public class SEMSContext : DbContext
    {
        public SEMSContext() : base("SEMSDb")
        {
        }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<User> Users { get; set; }
    }
}