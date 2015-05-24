﻿using System.Data.Entity.ModelConfiguration;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.Data.Configuration
{
    public class PassportInformationConfiguration : EntityTypeConfiguration<PassportInformation>
    {
        public PassportInformationConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id).HasColumnName("Passport ID");

            Property(o => o.Nationality).IsRequired().HasMaxLength(50);

            Property(o => o.PassportNumber).IsRequired().HasMaxLength(50);

            Property(o => o.ExpirationDate).IsRequired();

            HasRequired(o => o.Player).WithRequiredPrincipal(s => s.Passport).WillCascadeOnDelete(false);
        }
    }
}
