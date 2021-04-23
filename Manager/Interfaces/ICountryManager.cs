using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface ICountryManager
    {
        Task<List<Country>> GetCountriesAll();
        Task<Country> GetCountry(int Id);
        Task<Country> GetCountryByName(string Name);
        Task<Country> AddCountry(Country country);
        Task<Country> RemoveCountry(int Id);
        Task<Country> EditCountry(int Id, Country country);
    }
}
