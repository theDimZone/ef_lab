using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace EF_LAb.Manager
{
    public class MovieManager : IMovieManager
    {
        private ModelsContext _context;

        public MovieManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetMoviesAll()
        {

            List<Movie> movies = await _context.Movies.AsNoTracking().ToListAsync();
            return movies;
        }

        public async Task<List<Movie>> SearchMoviesByName(string query)
        {
            var results = _context.Movies
                .Where(f => f.Name.ToLower() == query.ToLower());

            List<Movie> movies = await results.ToListAsync<Movie>();

            return movies;
        }

        public async Task<List<Movie>> SearchMoviesByYear(int query)
        {
            var results = _context.Movies
                .Where(f => f.Year == query);

            List<Movie> movies = await results.ToListAsync<Movie>();

            return movies;
        }

        public async Task<Movie> GetMovie(int Id)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(u => u.Id == Id);
            return movie;
        }

        public async Task<Movie> GetMovieByNameAndYear(string Name, int Year)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(u => u.Name == Name && u.Year == Year );

            return movie;
        }


        public async Task<Movie> AddMovie(Movie movie)
        {
            var mv = _context.Movies.Add(movie);

            await _context.SaveChangesAsync();

            return mv.Entity;
        }

        public async Task<Movie> EditMovie(Movie movie)
        {
            var entity = await _context.Movies.FirstOrDefaultAsync(u => u.Id == movie.Id);

            if (entity != null)
            {
                entity.Country = movie.Country;
                entity.Details = movie.Details;
                entity.Director = movie.Director;
                entity.Name = movie.Name;
                entity.Year = movie.Year;

                // etc
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Movie> RemoveMovie(int Id)
        {
            var entity = await _context.Movies.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Movies.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Movie> AddActorToMovie(Actor actor, int MovieId)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(u => u.Id == MovieId);

            ActorMovie entity = new ActorMovie
            {
                Actor = actor,
                Movie = movie
            };

            movie.ActorMovies.Add(entity);

            await _context.SaveChangesAsync();

            return movie;
        }

        
        public async Task<Movie> RemoveActorFromMovie(int ActorId, int MovieId)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(u => u.Id == MovieId);

            if (movie != null)
            {
                ActorMovie actormovie = movie.ActorMovies.FirstOrDefault(am => am.ActorId == ActorId);
                
                movie.ActorMovies.Remove(actormovie);
            }

            await _context.SaveChangesAsync();

            return movie;
        }

        public async Task<Movie> AddGenreToMovie(Genre genre, int MovieId)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(u => u.Id == MovieId);

            GenreMovie entity = new GenreMovie
            {
                Genre = genre,
                Movie = movie
            };

            movie.GenreMovies.Add(entity);

            await _context.SaveChangesAsync();

            return movie;
        }


        public async Task<Movie> RemoveGenreFromMovie(int GenreId, int MovieId)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(u => u.Id == MovieId);

            if (movie != null)
            {
                GenreMovie genremovie = movie.GenreMovies.FirstOrDefault(am => am.GenreId == GenreId);

                movie.GenreMovies.Remove(genremovie);
            }

            await _context.SaveChangesAsync();

            return movie;
        }
    }

}
