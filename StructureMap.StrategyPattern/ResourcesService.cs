using System.Collections.Generic;
using System.Linq;

namespace StructureMap.StrategyPattern
{
    public class ResourcesService
    {
        private readonly IEnumerable<IResourcesRetriever> _resourcesRespositories;

        public ResourcesService(
            IEnumerable<IResourcesRetriever> resourcesRespositories)
        {
            _resourcesRespositories = resourcesRespositories;
        }

        public IEnumerable<Resource> GetResourcesByType(string resourceType)
        {
            return _resourcesRespositories
                .Single(x => x.CanRetrieve(resourceType))
                .Reteieve();
        }
    }

    public interface IResourcesRetriever
    {
        bool CanRetrieve(string resourceType);
        IEnumerable<Resource> Reteieve();
    }

    public class Type1ResourcesRetriever : IResourcesRetriever
    {
        public bool CanRetrieve(string resourceType)
        {
            return resourceType == "type1";
        }

        public IEnumerable<Resource> Reteieve()
        {
            return new List<Resource>
            {
                new Resource { Name = "Resource1" },
                new Resource { Name = "Resource2" },
                new Resource { Name = "Resource3" },
            };
        }
    }

    public class Type2ResourcesRetriever : IResourcesRetriever
    {
        public bool CanRetrieve(string resourceType)
        {
            return resourceType == "type2";
        }

        public IEnumerable<Resource> Reteieve()
        {
            return new List<Resource>
            {
                new Resource { Name = "Resource4" },
                new Resource { Name = "Resource5" },
                new Resource { Name = "Resource6" },
            };
        }
    }

    public class Resource
    {
        public string Name { get; set; }
    }
}
