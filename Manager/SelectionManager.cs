using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager
{
    public class SelectionManager : ISelectionManager
    {
        private ModelsContext _context;

        public SelectionManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Selection>> GetSelectionsAll()
        {

            List<Selection> selections = await _context.Selections.AsNoTracking().ToListAsync();
            return selections;
        }

        public async Task<Selection> GetSelection(int Id)
        {
            Selection selection = await _context.Selections.FirstOrDefaultAsync(u => u.Id == Id);
            return selection;
        }


        public async Task<Selection> AddSelection(Selection selection)
        {
            var sl = _context.Selections.Add(selection);

            await _context.SaveChangesAsync();

            return sl.Entity;
        }

        public async Task<Selection> EditSelection(Selection selection)
        {
            var entity = await _context.Selections.FirstOrDefaultAsync(u => u.Id == selection.Id);

            if (entity != null)
            {
                entity.Name = selection.Name;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Selection> RemoveSelection(int Id)
        {
            var entity = await _context.Selections.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Selections.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Selection> AddMovieToSelection(Movie movie, int SelectionId)
        {
            Selection selection = await _context.Selections.FirstOrDefaultAsync(u => u.Id == SelectionId);

            SelectionMovie entity = new SelectionMovie
            {
                Selection = selection,
                Movie = movie
            };

            selection.SelectionMovies.Add(entity);

            await _context.SaveChangesAsync();

            return selection;
        }


        public async Task<Selection> RemoveMovieFromSelection(int MovieId, int SelectionId)
        {
            Selection selection = await _context.Selections.FirstOrDefaultAsync(u => u.Id == SelectionId);

            if (selection != null)
            {
                SelectionMovie selectionmovie = selection.SelectionMovies.FirstOrDefault(am => am.MovieId == MovieId);

                selection.SelectionMovies.Remove(selectionmovie);
            }

            await _context.SaveChangesAsync();

            return selection;
        }
    }
}
