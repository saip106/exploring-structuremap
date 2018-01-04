using System.Collections.Generic;
using Good.BusinessInterfaces;
using Good.Common;

namespace Good.DataAccessLayer
{
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
}
