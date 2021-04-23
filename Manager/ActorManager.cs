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
    public class ActorManager : IActorManager
    {
        private ModelsContext _context;

        public ActorManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Actor>> GetActorsAll()
        {
            List<Actor> actors = await _context.Actors.AsNoTracking().ToListAsync();

            return actors;
        }

        public async Task<List<Actor>> SearchActorsByName(string query)
        {
             var results = _context.Actors
                 .Where(f => f.Name.ToLower() == query.ToLower());

            List<Actor> actors = await results.ToListAsync<Actor>();

            return actors;

        }
        public async Task<List<Actor>> SearchActorsByBirthYear(int query)
        {
            var results = _context.Actors
             .Where(f => f.Birthday.Year == query);

            List<Actor> actors = await results.ToListAsync<Actor>();

            return actors;
        }

        public async Task<Actor> GetActor(int Id)
        {
            Actor actor = await _context.Actors.FirstOrDefaultAsync(u => u.Id == Id);
            return actor;
        }

        public async Task<Actor> GetActorByName(string Name)
        {
            Actor actor = await _context.Actors.FirstOrDefaultAsync(u => u.Name == Name);
            return actor;
        }

        public async Task<Actor> AddActor(Actor actor)
        {
            Actor entity = new Actor
            {
                Country = actor.Country,
                Name = actor.Name,
                Birthday = actor.Birthday
            };

            var ac = _context.Actors.Add(entity);
            await _context.SaveChangesAsync();
            
            return ac.Entity;
        }

        public async Task<Actor> EditActor(Actor actor)
        {
            var entity = await _context.Actors.FirstOrDefaultAsync(u => u.Id == actor.Id);

            if (entity != null)
            {
                entity.Name = actor.Name;
                entity.Birthday = actor.Birthday;
                entity.Country = actor.Country;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Actor> RemoveActor(int Id)
        {
            var entity = await _context.Actors.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Actors.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
