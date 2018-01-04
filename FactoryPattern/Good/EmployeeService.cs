using System;
using System.Configuration;

namespace FactoryPattern.Good
{
    public class EmployeeService
    {
        private readonly EmployeeRepositoryFactory _employeeRepositoryFactory;

        public EmployeeService(EmployeeRepositoryFactory employeeRepositoryFactory)
        {
            _employeeRepositoryFactory = employeeRepositoryFactory;
        }

        public void Do()
        {
            var employeeRepository = _employeeRepositoryFactory.Build();
            employeeRepository.Add("foo");
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

    public class EmployeeRepositoryFactory
    {
        public IEmployeeRepository Build()
        {
            var respositoryType = ConfigurationManager.AppSettings["RepositoryType"];
            if (respositoryType == "CSV")
            {
                return  new CsvEmployeeRepository();
            }
            else if (respositoryType == "SQL")
            {
                return new SqlEmployeeRepository();
            }
            throw new Exception("Invalid repository type");
        }
    }
}
