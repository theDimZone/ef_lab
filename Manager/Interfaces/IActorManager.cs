using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface IActorManager
    {
        Task<List<Actor>> GetActorsAll();
        Task<List<Actor>> SearchActorsByName(string query);
        Task<List<Actor>> SearchActorsByBirthYear(int query);
        Task<Actor> GetActor(int Id);
        Task<Actor> GetActorByName(string Name);
        Task<Actor> AddActor(Actor actor);
        Task<Actor> RemoveActor(int Id);
        Task<Actor> EditActor(Actor actor);
    }
}
