using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_building_a_named_instance
    {
        private Container _container;

        [TestInitialize]
        public void Setup()
        {
            _container = new Container();

            _container.Configure(config =>
            {
                config.Scan(scanner =>
                {
                    scanner.AssemblyContainingType<ILogger>();
                    scanner.WithDefaultConventions();
                });
            });
        }

        [TestMethod]
        public void it_should_successfully_build_the_instance()
        {
            var employeeService = _container.GetInstance<ProviderService>();
            employeeService.Should().NotBeNull();
            employeeService.Should().BeOfType<ProviderService>();
        }
    }
}