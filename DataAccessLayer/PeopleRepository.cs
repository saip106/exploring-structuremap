using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetAll();
    }

    public class PeopleRepository : IPeopleRepository
    {
        public IEnumerable<Person> GetAll()
        {
            return new List<Person>
            {
                new Person { Name = "Roger Federer" },
                new Person { Name = "Rafael Nadal" },
                new Person { Name = "Andy Murry" },
            };
            
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
