using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Data
{
    public class CasinoContext : DbContext
    {
        public CasinoContext()
            :base("CasinoDataBase")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Type[] types = GetType().
                Assembly.GetTypes().
                    Where(x => x.BaseType != null && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();
            foreach (var type in types)
            {
                dynamic obj = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(obj);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
