using System;
using StructureMap.Sample;

namespace StructureMap.ConsoleApp
{
    public class ConsoleApplication
    {
        private readonly IProviderService _providerService;

        public ConsoleApplication(
            IProviderService providerService)
        {
            _providerService = providerService;
        }

        public void Run()
        {
            Console.WriteLine("Here is a list of providers:");
            foreach (var provider in _providerService.GetProviders())
            {
                Console.WriteLine(provider.Name);
            }
        }
    }
}
