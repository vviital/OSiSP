using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class AdministratorConfiguration : EntityTypeConfiguration<Administrator>
    {
        public AdministratorConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Administrator ID");

            Property(o => o.Birth).IsRequired();

            Property(o => o.Login).IsRequired().HasMaxLength(50);

            Property(o => o.Password).IsRequired().HasMaxLength(50);

            Property(o => o.Sex).IsRequired();

            Property(o => o.Surname).IsRequired().HasMaxLength(50);

            Property(o => o.FirstName).IsRequired().HasMaxLength(50);

            Property(o => o.Email).IsRequired();

            HasMany(o => o.ObservedPlayers).WithRequired(s => s.Admin).WillCascadeOnDelete(false);

            HasMany(o => o.SupervisedTournaments).WithRequired(s => s.Admin).WillCascadeOnDelete(false);

            
        }
    }
}
