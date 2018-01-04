using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_resolving_a_composition_root
    {
        private Container _container;

        [TestInitialize]
        public void Setup()
        {
            _container = new Container(config =>
            {
                config.Scan(scanner =>
                {
                    scanner.AssemblyContainingType<IProviderService>();
                    scanner.WithDefaultConventions();
                });
            });
        }

        [TestMethod]
        public void it_should_use_same_instance_for_common_dependencies()
        {
            var providerService = _container.GetInstance<IProviderService>();
            providerService.Logger.Should().BeSameAs(providerService.ProviderRepository.Logger);
        }
    }
}