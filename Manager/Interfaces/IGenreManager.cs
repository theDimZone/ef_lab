using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface IGenreManager
    {
        Task<List<Genre>> GetGenresAll();
        Task<Genre> GetGenre(int Id);
        Task<Genre> GetGenreByName(string Name);
        Task<Genre> AddGenre(Genre genre);
        Task<Genre> RemoveGenre(int Id);
        Task<Genre> EditGenre(Genre genre);
    }
}
