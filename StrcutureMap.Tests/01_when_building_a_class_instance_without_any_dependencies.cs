using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Sample;

namespace StrcutureMap.Tests
{
    [TestClass]
    public class when_building_a_class_instance_without_any_dependencies
    {
        private Container _container;

        [TestInitialize]
        public void Setup()
        {
            _container = new Container();
        }

        [TestMethod]
        public void it_should_successfully_build_the_instance()
        {
            var patientService = _container.GetInstance<PatientService>();
            patientService.Should().NotBeNull();
            patientService.Should().BeOfType<PatientService>();
        }
    }
}