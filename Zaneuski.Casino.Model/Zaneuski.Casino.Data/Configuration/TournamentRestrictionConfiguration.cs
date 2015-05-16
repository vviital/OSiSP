using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class TournamentRestrictionConfiguration : EntityTypeConfiguration<TournamentRestriction>
    {
        public TournamentRestrictionConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Tournament restriction ID");

            HasMany(o => o.Tournaments).WithRequired(s => s.Restriction);

            Property(o => o.Fee).IsRequired();

            Property(o => o.MinimumNumberOfWins).IsRequired();
        }
    }
}
