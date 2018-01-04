using System.Collections.Generic;
using DataAccessLayer;

namespace BussinessLayer
{
    public interface IPeopleService
    {
        IEnumerable<Person> GetAll();
    }

    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService()
        {
            _peopleRepository = new PeopleRepository();
        }

        public IEnumerable<Person> GetAll()
        {
            return _peopleRepository.GetAll();
        }
    }
}
