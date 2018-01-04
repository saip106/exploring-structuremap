using System.Configuration;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_building_a_class_instance_which_needs_data_via_constructor
    {
        private IContainer _container;

        [TestInitialize]
        public void Setup()
        {
            _container = new Container(c =>
            {
                //just for demo purposes, normally you don't want to embed the connection string directly into code.
                c.For<ICustomRepository>().Use<CustomRepository>().Ctor<string>().Is("YOUR_CONNECTION_STRING");
                
                /*
                //a better way would be providing a delegate that retrieves the value from your app config. 
                c.For<ICustomRepository>().Use<CustomRepository>().Ctor<string>().Is(() => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                */    
        });
        }

        [TestMethod]
        public void it_should_build_instances_by_type_and_name()
        {
            var customRepository = _container.GetInstance<ICustomRepository>();
            customRepository.Should().BeOfType<CustomRepository>();
            customRepository.ConnectionString.Should().Be("YOUR_CONNECTION_STRING");
        }
    }
}