using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_building_an_class_instance_with_dependencies_using_explicit_registration
    {
        private Container _container;

        [TestInitialize]
        public void Setup()
        {
            //option 1
            _container = new Container(config =>
            {
                config.For<ILogger>().Use<Logger>();
            });

            /*
            //option 2
            _container = new Container();
            _container.Configure(config =>
            {
                config.For<ILogger>().Use<Logger>();
            });
            */
        }

        [TestMethod]
        public void it_should_successfully_build_the_instance()
        {
            _container
                .GetInstance<EmployeeService>()
                .Should().BeOfType<EmployeeService>();
        }
    }
}
