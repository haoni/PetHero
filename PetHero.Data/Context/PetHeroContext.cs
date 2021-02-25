using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PetHero.Data.Models;

namespace PetHero.Data.Context
{
    public class PetHeroContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }

        public PetHeroContext(DbContextOptions<PetHeroContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().ToTable("Owner");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.10.123;Initial Catalog=PetHeroDataBase;User ID=sa;Password=@nuvem1234;");
        }

    }
}