using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configs
{
    public class BaseContext : IdentityDbContext<ApplicationUser>
    {
        public BaseContext ( DbContextOptions options ) : base( options )
        {

        }

        public DbSet<FinancialSystem> FinancialSystems { get; set; }
        public DbSet<UserFinancialSystem> UserFinancialSystems { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Expense> Expense { get; set; }

        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer( GetConnectionString() );
                base.OnConfiguring( optionsBuilder );
            }
        }

        protected override void OnModelCreating ( ModelBuilder builder )
        {
            builder.Entity<ApplicationUser>().ToTable( "AspNetUsers" ).HasKey( x => x.Id );
            base.OnModelCreating( builder );
        }

        public string GetConnectionString ()
        {
            return "Data Source=NBQSP-FC693;Initial Catalog=FinancialSystem;Integrated Security=False;User ID=sa;Password=localdb@admin1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        }
    }
}
