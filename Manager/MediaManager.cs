using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager
{
    public class MediaManager : IMediaManager
    {
        private ModelsContext _context;

        public MediaManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Media>> GetMediaAll()
        {
            List<Media> media = await _context.Media.AsNoTracking().ToListAsync();

            return media;
        }

        public async Task<Media> GetMedia(int Id)
        {
            Media media = await _context.Media.FirstOrDefaultAsync(u => u.Id == Id);
            return media;
        }

        public async Task<Media> AddMedia(Movie movie, Media media)
        {
            media.Movie = movie;
            media.MovieId = movie.Id;

            var md = _context.Media.Add(media);
            await _context.SaveChangesAsync();

            return md.Entity;
        }

        public async Task<Media> EditMedia(Media media)
        {
            var entity = await _context.Media.FirstOrDefaultAsync(u => u.Id == media.Id);

            if (entity != null)
            {
                entity.Name = media.Name;
                entity.Type = media.Type;
                entity.Url = media.Url;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Media> RemoveMedia(int Id)
        {
            var entity = await _context.Media.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Media.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
