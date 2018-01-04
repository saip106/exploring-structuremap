namespace Coupling.Sample
{
    public class Sample4
    {
        public class CustomerRepository
        {
            private readonly IDatabase _database;

            public CustomerRepository()
            {
                _database = new Database();
            }

            public void Add(string customerName)
            {
                _database.AddRow("Customer", customerName);
            }
        }

        public interface IDatabase
        {
            void AddRow(string table, string value);
        }

        public class Database : IDatabase
        {
            public void AddRow(string table, string value)
            {
            }
        }
    }
}