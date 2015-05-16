using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    class TournamentConfiguration : EntityTypeConfiguration<Tournament>
    {
        public TournamentConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Tournament ID");

            HasMany(o => o.Rounds).WithRequired(s => s.Tournament);

            Property(o => o.Schedule).IsRequired();

            Property(o => o.TournamentName).IsRequired();
        }
    }
}
