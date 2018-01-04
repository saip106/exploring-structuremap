namespace StructureMap.Sample
{
    public class ProviderMapper
    {
        private readonly ILogger _logger;

        public ProviderMapper(
            ILogger logger)
        {
            _logger = logger;
        }
    }
}