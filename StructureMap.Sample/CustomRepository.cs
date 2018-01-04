namespace StructureMap.Sample
{
    public interface ICustomRepository
    {
        string ConnectionString { get; }
        void Add(string data);
    }

    public class CustomRepository : ICustomRepository
    {
        public string ConnectionString { get; }

        public CustomRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Add(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}