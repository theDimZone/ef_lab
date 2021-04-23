using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager
{
    public class GenreManager : IGenreManager
    {
        private ModelsContext _context;

        public GenreManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Genre>> GetGenresAll()
        {
            List<Genre> genres = await _context.Genres.AsNoTracking().ToListAsync();

            return genres;
        }

        public async Task<Genre> GetGenre(int Id)
        {
            Genre genre = await _context.Genres.FirstOrDefaultAsync(u => u.Id == Id);
            return genre;
        }

        public async Task<Genre> GetGenreByName(string Name)
        {
            Genre genre = await _context.Genres.FirstOrDefaultAsync(u => u.Name == Name);
            return genre;
        }

        public async Task<Genre> AddGenre(Genre genre)
        {
            Genre entity = new Genre
            {
                Name = genre.Name
            };
            
            var ge = _context.Genres.Add(entity);
            await _context.SaveChangesAsync();

            return ge.Entity;
        }

        public async Task<Genre> EditGenre(Genre genre)
        {
            var entity = await _context.Genres.FirstOrDefaultAsync(u => u.Id == genre.Id);

            if (entity != null)
            {
                entity.Name = genre.Name;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Genre> RemoveGenre(int Id)
        {
            var entity = await _context.Genres.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Genres.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
