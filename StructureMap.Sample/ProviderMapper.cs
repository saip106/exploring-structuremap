namespace StructureMap.Sample
{
    public class ProviderMapper
    {
        public ILogger Logger { get; }

        public ProviderMapper(
            ILogger logger)
        {
            Logger = logger;
        }

        public void Map()
        {
            
        }
    }
}