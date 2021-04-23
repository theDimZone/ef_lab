using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface ISelectionManager
    {
        Task<List<Selection>> GetSelectionsAll();
        Task<Selection> GetSelection(int Id);
        Task<Selection> AddSelection(Selection selection);
        Task<Selection> RemoveSelection(int Id);
        Task<Selection> EditSelection(Selection selection);

        Task<Selection> AddMovieToSelection(Movie movie, int SelectionId);
        Task<Selection> RemoveMovieFromSelection(int MovieId, int SelectionId);
    }
}
