using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class GameTypeConfiguration : EntityTypeConfiguration<GameType>
    {
        public GameTypeConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Game type ID");

            Property(o => o.Type).IsRequired().HasMaxLength(50);

            HasMany(o => o.Tournaments).WithRequired(s => s.GameType).WillCascadeOnDelete(false);
        }
    }
}
