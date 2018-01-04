using System.Collections.Generic;
using Good.BusinessInterfaces;
using Good.Common;
using Good.PresentationInterfaces;

namespace Good.BusinessLayer
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public IEnumerable<Person> GetAll()
        {
            return _peopleRepository.GetAll();
        }
    }
}
