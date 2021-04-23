using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_LAb.Controllers
{
    public class ActorsController : Controller
    {
        private IActorManager _actorManager;
        private ICountryManager _countryManager;

        public ActorsController(IActorManager actorManager, ICountryManager countryManager)
        {
            _actorManager = actorManager;
            _countryManager = countryManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            List<Actor> actors = await _actorManager.GetActorsAll();

            return View(actors);
        }
        #endregion

        #region Search
        [HttpGet]
        public async Task<ViewResult> Search(string q, string target)
        {
            List<Actor> actors;

            if (target == "Name")
            {
                actors = await _actorManager.SearchActorsByName(q);
            }
            else
            {
                actors = await _actorManager.SearchActorsByBirthYear(Int32.Parse(q));
            }

            return View(actors);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Actor actor = await _actorManager.GetActor(Id);
            //System.Diagnostics.Debug.WriteLine("Actor: " + actor.ToString());
            return View(actor);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(string CountryName, Actor actor)
        {
            
            Country country = await _countryManager.GetCountryByName(CountryName);
            if(country == null)
            {
                country = await _countryManager.AddCountry(new Country { Name = CountryName });
            }

            actor.Country = country;
            Actor ac = await _actorManager.AddActor(actor);

            return RedirectToAction("Show", "Actors", new { Id = ac.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Actor actor = await _actorManager.GetActor(Id);

            return View(actor);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Actor actor, string CountryName)
        {
            Country country = await _countryManager.GetCountryByName(CountryName);
            if (country == null)
            {
                country = await _countryManager.AddCountry(new Country { Name = CountryName });
            }

            actor.Country = country;
            Actor ac = await _actorManager.EditActor(actor);

            return RedirectToAction("Show", "Actors", new { Id = ac.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Actor ac = await _actorManager.RemoveActor(Id);

            return RedirectToAction("Index", "Actors");

        }
        #endregion
    }
}
