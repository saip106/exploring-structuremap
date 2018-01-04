using System;

namespace CreationInversion.Samples.ServiceLocator.Good
{
    public class EmployeeService
    {
        private readonly ServiceLocator _serviceLocator;

        public EmployeeService(ServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void Do()
        {
            var employeeRepository = _serviceLocator.Build<IEmployeeRepository>();
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
            throw new NotImplementedException();
        }
    }

    public class CsvEmployeeRepository : IEmployeeRepository
    {
        public void Add(string name)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ServiceLocator
    {
        public T Build<T>() where T : class 
        {
            throw new NotImplementedException();
        }
    }
}
