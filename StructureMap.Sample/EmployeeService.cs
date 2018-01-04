namespace StructureMap.Sample
{
    public class EmployeeService
    {
        private readonly ILogger _logger;

        public EmployeeService(
            ILogger logger)
        {
            _logger = logger;
        }
    }
}