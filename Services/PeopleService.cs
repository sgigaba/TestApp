namespace TestApp.Services
{
    using Newtonsoft.Json;

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
            var lastId = People.Last().Id;

            JsonConvert.PopulateObject(values, model);
            model.Id = lastId + 1;
            
            People.Add(model);

            return People;
        }

        public static List<Person> GeneratePeople()
        {
            var person1 = new Person()
            {
                Id = 1,
                Name = "Kazuhiko Hibima",
                Age = 25
            };

            var person2 = new Person()
            {
                Id = 2,
                Name = "Seiji Kumaizumi",
                Age = 33
            };

            var person3 = new Person()
            {
                Id = 3,
                Name = "Officer Hirokazu Ukita",
                Age = 57
            };

            var person4 = new Person()
            {
                Id = 4,
                Name = "Tayoshi Murao",
                Age = 30
            };

            var person5 = new Person()
            {
                Id = 5,
                Name = "Naomi Misora",
                Age = 23
            };

            var person6 = new Person()
            {
                Id = 6,
                Name = "Raye Penber",
                Age = 15
            };

            var person7 = new Person()
            {
                Id = 7,
                Name = "Kiichiro Osoreda",
                Age = 27
            };

            var person8 = new Person()
            {
                Id = 8,
                Name = "Kurou Otoharada",
                Age = 18
            };

            var person9 = new Person()
            {
                Id = 9,
                Name = "Takuo Shibuimaru",
                Age = 12
            };

            var person10 = new Person()
            {
                Id = 10,
                Name = "Kiichiro Osoreda",
                Age = 55
            };

            var person11 = new Person()
            {
                Id = 11,
                Name = "Naoki Koro Kitayama",
                Age = 25
            };

            var person13 = new Person()
            {
                Id = 13,
                Name = "Lind L. Tailor",
                Age = 60
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
