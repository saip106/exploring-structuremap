using System.Collections.Generic;

namespace StructureMap.Sample
{
    public interface IProviderService
    {
        ILogger Logger { get; }
        IProviderRepository ProviderRepository { get; }
        IEnumerable<Provider> GetProviders();
    }

    public class ProviderService : IProviderService
    {
        private readonly ProviderMapper _providerMapper;

        public ProviderService(
            IProviderRepository providerRepository,
            ProviderMapper providerMapper,
            ILogger logger)
        {
            _providerMapper = providerMapper;
            ProviderRepository = providerRepository;
            Logger = logger;
        }

        public IProviderRepository ProviderRepository { get; }
        public ILogger Logger { get; }

        public IEnumerable<Provider> GetProviders()
        {
            _providerMapper.Map();
            return ProviderRepository.GetProviders();
        }
    }

    public class Provider
    {
        public string Name { get; set; }
    }
}