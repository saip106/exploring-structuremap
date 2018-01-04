using System.Collections.Generic;

namespace StructureMap.Sample
{
    public interface IProviderRepository
    {
        IEnumerable<Provider> GetProviders();
    }

    public class ProviderRepository : IProviderRepository
    {
        private readonly ILogger _logger;

        public ProviderRepository(
            ILogger logger)
        {
            _logger = logger;
        }

        public IEnumerable<Provider> GetProviders()
        {
            return new[]
            {
                new Provider { Name = "Warren Buffet" },
                new Provider { Name = "Bill Gates" },
                new Provider { Name = "Steve Jobs" },
            };
        }
    }
}