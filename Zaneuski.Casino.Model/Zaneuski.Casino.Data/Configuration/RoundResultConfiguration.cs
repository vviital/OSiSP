using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class RoundResultConfiguration : EntityTypeConfiguration<RoundResult>
    {
        public RoundResultConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Round result ID");

            Property(o => o.Gain).IsRequired();
        }
    }
}
