using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace WebAPIControllers
{
    public class HomeWebAPI : Controller
    {
        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            var person1 = new Person()
            {
                Id = 1,
                Name = "Person1",
                Age = 1
            };

            var person2 = new Person()
            {
                Id = 2,
                Name = "Person2",
                Age = 1
            };

            var person3 = new Person()
            {
                Id = 3,
                Name = "Person4",
                Age = 1
            };

            var person4 = new Person()
            {
                Id = 4,
                Name = "Person5",
                Age = 1
            };

            var person5 = new Person()
            {
                Id = 5,
                Name = "Person6",
                Age = 1
            };

            var person6 = new Person()
            {
                Id = 6,
                Name = "Person7",
                Age = 1
            };

            var person7 = new Person()
            {
                Id = 7,
                Name = "Person8",
                Age = 1
            };

            var person8 = new Person()
            {
                Id = 8,
                Name = "Person9",
                Age = 1
            };

            var person9 = new Person()
            {
                Id = 9,
                Name = "Person10",
                Age = 1
            };

            var person10 = new Person()
            {
                Id = 10,
                Name = "Person11",
                Age = 1
            };

            var person11 = new Person()
            {
                Id = 11,
                Name = "Person12",
                Age = 1
            };

            var person13 = new Person()
            {
                Id = 13,
                Name = "Person13",
                Age = 1
            };

            var people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);
            people.Add(person8);
            people.Add(person9);
            people.Add(person10);
            people.Add(person11);
            people.Add(person13);

            return this.Json(DataSourceLoader.Load(people, loadOptions));
        }
    }
}
