using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data
{
    public class CasinoContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<RoundResult> RoundResults { get; set; }
        public DbSet<PassportInformation> PassportInformations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<TournamentRestriction> TournamentRestrictions { get; set; }
        public DbSet<GameType> GameTypes { get; set; }

        public CasinoContext()
            :base("CasinoDataBase")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Type[] types = GetType().
                Assembly.GetTypes().Where(x => x.BaseType != null && x.BaseType.IsGenericType && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();//.
                   // Where(x => x.BaseType != null && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();
            foreach (var type in types)
            {
                dynamic obj = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(obj);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
