using System.Configuration;

namespace FactoryPattern.Bad
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            var respositoryType = ConfigurationManager.AppSettings["RepositoryType"];
            if (respositoryType == "CSV")
            {
                _employeeRepository = new CsvEmployeeRepository();
            }
            else if (respositoryType == "SQL")
            {
                _employeeRepository = new SqlEmployeeRepository();
            }
        }

        public void Do()
        {
            _employeeRepository.Add("foo");
        }
    }

    public interface IEmployeeRepository
    {
        void Add(string name);
    }

    public class SqlEmployeeRepository : IEmployeeRepository
    {
        public void Add(string name)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CsvEmployeeRepository : IEmployeeRepository
    {
        public void Add(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
