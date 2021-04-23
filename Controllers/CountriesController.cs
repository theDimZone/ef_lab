using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_LAb.Controllers
{
    public class CountriesController : Controller
    {
        private ICountryManager _countryManager;

        public CountriesController(ICountryManager countryManager)
        {
            _countryManager = countryManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            List<Country> countries = await _countryManager.GetCountriesAll();

            return View(countries);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Country country = await _countryManager.GetCountry(Id);

            return View(country);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Country country)
        {
            Country cy = await _countryManager.AddCountry(country);

            return RedirectToAction("Show", "Countries", new { Id = cy.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Country country = await _countryManager.GetCountry(Id);

            return View(country);
        }

        [HttpPost]
        public async Task<ActionResult> Update(int Id, Country country)
        {
            Country cy = await _countryManager.EditCountry(Id, country);

            return RedirectToAction("Show", "Countries", new { Id = cy.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Country cy = await _countryManager.RemoveCountry(Id);

            return RedirectToAction("Index", "Countries");

        }
        #endregion
    }
}
