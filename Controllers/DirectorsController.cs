using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_LAb.Controllers
{
    public class DirectorsController : Controller
    {
        private IDirectorManager _directorManager;
        private ICountryManager _countryManager;

        public DirectorsController(IDirectorManager directorManager, ICountryManager countryManager)
        {
            _directorManager = directorManager;
            _countryManager = countryManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            List<Director> directors = await _directorManager.GetDirectorsAll();

            return View(directors);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Director director = await _directorManager.GetDirector(Id);
            //System.Diagnostics.Debug.WriteLine("Actor: " + actor.ToString());
            return View(director);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(string CountryName, Director director)
        {

            Country country = await _countryManager.GetCountryByName(CountryName);
            if (country == null)
            {
                country = await _countryManager.AddCountry(new Country { Name = CountryName });
            }

            director.Country = country;
            Director di = await _directorManager.AddDirector(director);

            return RedirectToAction("Show", "Directors", new { Id = di.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Director director = await _directorManager.GetDirector(Id);

            return View(director);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Director director, string CountryName)
        {
            Country country = await _countryManager.GetCountryByName(CountryName);
            if (country == null)
            {
                country = await _countryManager.AddCountry(new Country { Name = CountryName });
            }

            director.Country = country;
            Director di = await _directorManager.EditDirector(director);

            return RedirectToAction("Show", "Directors", new { Id = di.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Director di = await _directorManager.RemoveDirector(Id);

            return RedirectToAction("Index", "Directors");

        }
        #endregion
    }
}
