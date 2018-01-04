namespace Coupling.Sample
{
    public class Sample1
    {
        public class CustomerRepository
        {
            private readonly Database _database;

            public CustomerRepository()
            {
                _database = new Database();
            }

            public void Add(string customerName)
            {
                _database.AddRow("Customer", customerName);
            }
        }

        public class Database
        {
            public void AddRow(string table, string value)
            {
            }
        }
    }
}
