namespace StructureMap.Sample
{
    public interface IRepository
    {
        void Add(string data);
    }

    public class SqlRepository : IRepository
    {
        public void Add(string data)
        {
            throw new System.NotImplementedException();
        }
    }

    public class OracleRepository : IRepository
    {
        public void Add(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}
