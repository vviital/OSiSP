using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Country code");

            HasMany(o => o.Players).WithRequired(s => s.Country).WillCascadeOnDelete(false);//.HasForeignKey(p => p.CountryId);

            HasMany(o => o.Administrators).WithRequired(s => s.Country).WillCascadeOnDelete(false);

            Property(o => o.CountryName).IsRequired().HasMaxLength(50);
        }
    }
}
