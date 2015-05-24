using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    class TournamentConfiguration : EntityTypeConfiguration<Tournament>
    {
        public TournamentConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Tournament ID");

            HasMany(o => o.Rounds).WithRequired(s => s.Tournament).WillCascadeOnDelete(false);

            Property(o => o.Schedule).IsRequired();

            Property(o => o.TournamentName).IsRequired();
        }
    }
}
