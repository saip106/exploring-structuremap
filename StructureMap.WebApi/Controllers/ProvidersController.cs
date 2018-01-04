using System.Collections.Generic;
using System.Web.Http;
using StructureMap.Sample;

namespace StructureMap.WebApi.Controllers
{
    public class ProvidersController : ApiController
    {
        public IEnumerable<Provider> Get()
        {
            var logger = new Logger();
            var providerRepository = new ProviderRepository(logger);
            var providerMapper = new ProviderMapper(logger);
            var providerService = new ProviderService(providerRepository, providerMapper, logger);
            return providerService.GetProviders();
        }
    }

    //public class ProvidersController : ApiController
    //{
    //    private readonly IProviderService _providerService;

    //    public ProvidersController(
    //        IProviderService providerService)
    //    {
    //        _providerService = providerService;
    //    }

    //    public IEnumerable<Provider> Get()
    //    {
    //        return _providerService.GetProviders();
    //    }
    //}
}
