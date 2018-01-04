namespace Coupling.Sample
{
    public class Sample2
    {
        public class CustomerRepository
        {
            private readonly Database _database;

            public CustomerRepository(Database database)
            {
                _database = database;
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
