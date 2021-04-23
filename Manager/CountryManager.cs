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
    public class CountryManager : ICountryManager
    {
        private ModelsContext _context;

        public CountryManager(ModelsContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetCountriesAll()
        {
            List<Country> countries = await _context.Countries.AsNoTracking().ToListAsync(); 
            return countries;
        }

        public async Task<Country> GetCountry(int Id)
        {
            Country country = await _context.Countries.FirstOrDefaultAsync(u => u.Id == Id);
            return country;
        }
        public async Task<Country> GetCountryByName(string Name)
        {
            Country country = await _context.Countries.FirstOrDefaultAsync(u => u.Name == Name);
            return country;
        }

        public async Task<Country> AddCountry(Country country)
        {
            //country.Id = int.Newint();
            var cy = _context.Countries.Add(country);

            await _context.SaveChangesAsync();

            return cy.Entity;
        }

        public async Task<Country> EditCountry(int Id, Country country)
        {
            var entity = await _context.Countries.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                entity.Name = country.Name;
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Country> RemoveCountry(int Id)
        {
            var entity = await _context.Countries.FirstOrDefaultAsync(u => u.Id == Id);

            if (entity != null)
            {
                _context.Countries.Remove(entity);
            }

            await _context.SaveChangesAsync();

            return entity;
        }
    }

}
