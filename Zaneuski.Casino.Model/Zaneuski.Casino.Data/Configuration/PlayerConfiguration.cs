using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        public PlayerConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Player ID");

            Property(o => o.Login).IsRequired().HasMaxLength(30);

            Property(o => o.Password).IsRequired().HasMaxLength(30);

            Property(o => o.Surname).IsRequired().HasMaxLength(50);

            Property(o => o.FirstName).IsRequired().HasMaxLength(50);

            Property(o => o.Birth).IsRequired();

            Property(o => o.Email).IsRequired().HasMaxLength(50);

            Property(o => o.Sex).IsRequired();

            Property(o => o.PhoneNumber).IsRequired().HasMaxLength(50);

            Property(o => o.VerifyFlag).IsRequired();

            Property(o => o.AccountBalance).IsRequired();

            HasMany(o => o.Tournaments).WithMany(s => s.Participants);

            HasMany(o => o.haveFriends).WithMany(s => s.isFriends);

            HasMany(o => o.RoundResults).WithRequired(s => s.Participant);
        }
    }
}
