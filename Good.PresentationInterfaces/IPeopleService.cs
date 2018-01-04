using System.Collections.Generic;
using Good.Common;

namespace Good.PresentationInterfaces
{
    public interface IPeopleService
    {
        IEnumerable<Person> GetAll();
    }
}
