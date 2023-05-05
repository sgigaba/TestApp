using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.WebAPIControllers
{
    public class HomeWebAPIController : Controller
    {
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            var person = new Person()
            {
                Id = 1,
                Name = "Test",
                Age = 1
            };

            var people = new List<Person>() { person };
            return this.Json(DataSourceLoader.Load(people, loadOptions));
        }
    }
}
