using StructureMap.Sample;

namespace StructureMap.ConsoleApp
{
    public class Bootstrapper
    {
        public static IContainer Bootstrap()
        {
            var container = new Container();
            container.Configure(config =>
            {
                config.Scan(scanner =>
                {
                    scanner.AssemblyContainingType<ILogger>();
                    scanner.WithDefaultConventions();
                });
            });

            return container;
        }
    }
}