using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_resolving_a_plugin_type_that_has_multiple_implementations
    {
        private Container _container;

        [TestInitialize]
        public void Setup()
        {
            _container = new Container(config =>
            {
                config.Scan(scanner =>
                {
                    scanner.AssemblyContainingType<IRepository>();
                    scanner.AddAllTypesOf<IRepository>();
                });
            });
        }

        [TestMethod]
        public void it_should_get_all_instances()
        {
            _container
                .GetAllInstances<IRepository>()
                .Count()
                .Should().Be(2);
        }
    }
}