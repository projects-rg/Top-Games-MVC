using System;
using Microsoft.EntityFrameworkCore;


namespace UWS.Shared
{
    public class GamesDB : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games{get;set;}
        public DbSet<Publisher> Publishers{get;set;}

        public GamesDB(DbContextOptions<GamesDB> options)
          : base(options) { }
        
        protected override void OnModelCreating(
          ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<Category>()
            //   .HasMany(c => c.Games)
            //   .WithOne(p => p.Category);

            // modelBuilder.Entity<Game>()
            //   .HasOne(p => p.Category)
            //   .WithMany(c => c.Games);

            //  modelBuilder.Entity<Game>()
            //   .HasOne(p => p.PublisherID)
            //   .WithMany(c => c.Games);

        }



    }
}
