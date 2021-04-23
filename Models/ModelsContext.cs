using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EF_LAb.Models
{
    
    public class ModelsContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Selection> Selections { get; set; }


        //public DbSet<ActorMovie> ActorMovies { get; set; }
        //public DbSet<GenreMovie> GenreMovies { get; set; }
        //public DbSet<SelectionMovie> SelectionMovies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MikroKinopoisk;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // many to many: actor - movie
            modelBuilder.Entity<ActorMovie>()
                .HasKey(t => new { t.ActorId, t.MovieId });

            modelBuilder.Entity<ActorMovie>()
                .HasOne(pt => pt.Actor)
                .WithMany(p => p.ActorMovies)
                .HasForeignKey(pt => pt.ActorId);

            modelBuilder.Entity<ActorMovie>()
                .HasOne(pt => pt.Movie)
                .WithMany(t => t.ActorMovies)
                .HasForeignKey(pt => pt.MovieId);

            // many to many: genre - movie
            modelBuilder.Entity<GenreMovie>()
                .HasKey(t => new { t.GenreId, t.MovieId });

            modelBuilder.Entity<GenreMovie>()
                .HasOne(pt => pt.Genre)
                .WithMany(p => p.GenreMovies)
                .HasForeignKey(pt => pt.GenreId);

            modelBuilder.Entity<GenreMovie>()
                .HasOne(pt => pt.Movie)
                .WithMany(t => t.GenreMovies)
                .HasForeignKey(pt => pt.MovieId);

            // many to many: selection - movie
            modelBuilder.Entity<SelectionMovie>()
                .HasKey(t => new { t.SelectionId, t.MovieId });

            modelBuilder.Entity<SelectionMovie>()
                .HasOne(pt => pt.Selection)
                .WithMany(p => p.SelectionMovies)
                .HasForeignKey(pt => pt.SelectionId);

            modelBuilder.Entity<SelectionMovie>()
                .HasOne(pt => pt.Movie)
                .WithMany(t => t.SelectionMovies)
                .HasForeignKey(pt => pt.MovieId);
        }
    }
    
}
