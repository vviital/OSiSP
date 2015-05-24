using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class RoundConfiguration : EntityTypeConfiguration<Round>
    {
        public RoundConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Round ID");

            Property(o => o.RoomNumber).IsRequired();

            HasMany(o => o.RoundResults).WithRequired(s => s.TournamentRoom).WillCascadeOnDelete(false);
        }
    }
}
