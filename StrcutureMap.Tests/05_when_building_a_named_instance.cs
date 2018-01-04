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
                    scanner.AssemblyContainingType<IRepository>();
                    scanner.WithDefaultConventions();
                });

                config.For<IRepository>().Add<SqlRepository>().Named("sql");
                config.For<IRepository>().Add<OracleRepository>().Named("oracle");
            });
        }

        [TestMethod]
        public void it_should_build_instances_by_type_and_name()
        {
            _container
                .GetInstance<IRepository>("sql")
                .Should().BeOfType<SqlRepository>();

            _container
                .GetInstance<IRepository>("oracle")
                .Should().BeOfType<OracleRepository>();
        }
    }
}