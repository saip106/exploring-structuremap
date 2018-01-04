using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_registering_using_registry
    {
        private IContainer _container;

        [TestInitialize]
        public void Setup()
        {
            //option 1
            _container = new Container(new MyRegistry());

            //option 3
            //_container = Container.For<MyRegistry>();

            //option 2
            //_container = new Container(x =>
            //{
            //    x.AddRegistry<MyRegistry>();
            //});
        }

        [TestMethod]
        public void it_should_build_instances_successfully()
        {
            _container
                .GetInstance<IRepository>("sql")
                .Should().BeOfType<SqlRepository>();

            _container
                .GetInstance<IRepository>("oracle")
                .Should().BeOfType<OracleRepository>();
        }
    }

    public class MyRegistry : Registry
    {
        public MyRegistry()
        {
            For<IRepository>().Add<SqlRepository>().Named("sql");
            For<IRepository>().Add<OracleRepository>().Named("oracle");
        }
    }
}