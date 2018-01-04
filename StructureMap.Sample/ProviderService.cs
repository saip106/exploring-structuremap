using System.Collections.Generic;

namespace StructureMap.Sample
{
    public interface IProviderService
    {
        ILogger Logger { get; }
        IEnumerable<Provider> GetProviders();
    }

    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        private readonly ProviderMapper _providerMapper;

        public ProviderService(
            IProviderRepository providerRepository,
            ProviderMapper providerMapper,
            ILogger logger)
        {
            _providerRepository = providerRepository;
            _providerMapper = providerMapper;
            Logger = logger;
        }

        public ILogger Logger { get; }

        public IEnumerable<Provider> GetProviders()
        {
            return _providerRepository.GetProviders();
        }
    }

    public class Provider
    {
        public string Name { get; set; }
    }
}