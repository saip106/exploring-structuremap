using StructureMap.Sample;

namespace StructureMap.ServiceLocator
{
    public class ProviderController
    {
        private readonly IContainer _container;

        public ProviderController(
            IContainer container)
        {
            _container = container;
        }

        public void Do()
        {
            var logger = _container.GetInstance<ILogger>();
            var providerService = _container.GetInstance<IProviderService>();

            providerService.GetProviders();
            logger.Log("foo");
        }
    }
}
