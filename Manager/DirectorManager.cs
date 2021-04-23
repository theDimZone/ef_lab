using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager
{
    public class DirectorManager : IDirectorManager
    {
        private ModelsContext _context;

        public DirectorManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Director>> GetDirectorsAll()
        {
            List<Director> directors = await _context.Directors.AsNoTracking().ToListAsync();

            return directors;
        }

        public async Task<Director> GetDirector(int Id)
        {
            Director director = await _context.Directors.FirstOrDefaultAsync(u => u.Id == Id);
            return director;
        }

        public async Task<Director> GetDirectorByName(string Name)
        {
            Director director = await _context.Directors.FirstOrDefaultAsync(u => u.Name == Name);
            return director;
        }

        public async Task<Director> AddDirector(Director director)
        {
            Director entity = new Director
            {
                Country = director.Country,
                Name = director.Name,
                Birthday = director.Birthday
            };

            var ac = _context.Directors.Add(entity);
            await _context.SaveChangesAsync();

            return ac.Entity;
        }

        public async Task<Director> EditDirector(Director director)
        {
            var entity = await _context.Directors.FirstOrDefaultAsync(u => u.Id == director.Id);

            if (entity != null)
            {
                entity.Name = director.Name;
                entity.Birthday = director.Birthday;
                entity.Country = director.Country;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Director> RemoveDirector(int Id)
        {
            var entity = await _context.Directors.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Directors.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
