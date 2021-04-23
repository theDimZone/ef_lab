using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface IDirectorManager
    {
        Task<List<Director>> GetDirectorsAll();
        Task<Director> GetDirector(int Id);
        Task<Director> GetDirectorByName(string Name);
        Task<Director> AddDirector(Director director);
        Task<Director> RemoveDirector(int Id);
        Task<Director> EditDirector(Director director);
    }
}
