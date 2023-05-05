namespace TestApp.Services
{
    using Newtonsoft.Json;
    using System.Runtime.CompilerServices;
    using TestApp.Models;

    public class PeopleService
    {
        public static List<Person> People { get; set; }

        static PeopleService()
        {
            People = new List<Person>();
            People = GeneratePeople();
        }

        public List<Person> Add(string values)
        {
            var model = new Person();

            JsonConvert.PopulateObject(values, model);
            People.Add(model);

            return People;
        }

        public static List<Person> GeneratePeople()
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

            People.Add(person1);
            People.Add(person2);
            People.Add(person3);
            People.Add(person4);
            People.Add(person5);
            People.Add(person6);
            People.Add(person7);
            People.Add(person8);
            People.Add(person9);
            People.Add(person10);
            People.Add(person11);
            People.Add(person13);

            return People;
        }
    }
}
