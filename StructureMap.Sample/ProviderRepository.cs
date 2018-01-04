using System.Collections.Generic;

namespace StructureMap.Sample
{
    public interface IProviderRepository
    {
        ILogger Logger { get; }
        IEnumerable<Provider> GetProviders();
    }

    public class ProviderRepository : IProviderRepository
    {
        public ILogger Logger { get; }

        public ProviderRepository(
            ILogger logger)
        {
            Logger = logger;
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