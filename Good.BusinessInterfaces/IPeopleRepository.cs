using System.Collections.Generic;
using Good.Common;

namespace Good.BusinessInterfaces
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetAll();
    }
}
