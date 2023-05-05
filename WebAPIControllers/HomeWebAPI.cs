using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using TestApp.Services;

namespace WebAPIControllers
{
    public class HomeWebAPI : Controller
    {
        private readonly PeopleService peopleService;
        public HomeWebAPI(PeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            var people = peopleService.GeneratePeople();

            return this.Json(DataSourceLoader.Load(people, loadOptions));
        }
    }
}
