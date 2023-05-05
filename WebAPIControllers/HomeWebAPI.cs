﻿using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection;
using TestApp.Models;
using TestApp.Services;

namespace WebAPIControllers
{
    public class HomeWebAPI : Controller
    {
        private readonly PeopleService peopleService;
        private List<Person> People;

        public HomeWebAPI(PeopleService peopleService)
        {
            this.peopleService = peopleService;
            People = PeopleService.People;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            return this.Json(DataSourceLoader.Load(People, loadOptions));
        }

        [HttpPost]
        public IActionResult Add(string values) 
        {
            People = peopleService.Add(values);

            return this.Ok(People);
        }
    }
}
