namespace AdapterMethodClass
{
    public class DataRecord
    {
        public int Id { get; set; }
        public string Data { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Data: {Data}";
        }
    }
}

// IDataSource.cs
namespace AdapterMethodClass
{
    public interface IDataSource
    {
        List<DataRecord> GetData();
    }
}

// SQLDatabase.cs
namespace AdapterMethodClass
{
    public class SQLDatabase
    {
        public List<List<object>> ExecuteQuery()
        {
            // Simulate SQL ResultSet: list of rows, each row is list of columns (id, data)
            return new List<List<object>>
            {
                new List<object> { 1, "SQL Data 1" },
                new List<object> { 2, "SQL Data 2" },
                new List<object> { 3, "SQL Data 3" }
            };
        }
    }
}

// NoSQLDatabase.cs
namespace AdapterMethodClass
{
    public class NoSQLDatabase
    {
        public List<Dictionary<string, object>> FetchDocuments()
        {
            // Simulate NoSQL documents: list of dictionaries
            return new List<Dictionary<string, object>>
            {
                new Dictionary<string, object> { { "_id", 1 }, { "content", "NoSQL Data 1" } },
                new Dictionary<string, object> { { "_id", 2 }, { "content", "NoSQL Data 2" } },
                new Dictionary<string, object> { { "_id", 3 }, { "content", "NoSQL Data 3" } }
            };
        }
    }
}

// XMLDatabase.cs
namespace AdapterMethodClass
{
    public class XMLNode
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class XMLDatabase
    {
        public List<XMLNode> ReadXML()
        {
            // Simulate XML nodes
            return new List<XMLNode>
            {
                new XMLNode { Id = 1, Value = "XML Data 1" },
                new XMLNode { Id = 2, Value = "XML Data 2" },
                new XMLNode { Id = 3, Value = "XML Data 3" }
            };
        }
    }
}

// SQLAdapter.cs
namespace AdapterMethodClass
{
    public class SQLAdapter : IDataSource
    {
        private readonly SQLDatabase _sqlDb;

        public SQLAdapter(SQLDatabase sqlDb)
        {
            _sqlDb = sqlDb;
        }

        public List<DataRecord> GetData()
        {
            var resultSet = _sqlDb.ExecuteQuery();
            var records = new List<DataRecord>();

            foreach (var row in resultSet)
            {
                int id = Convert.ToInt32(row[0]);
                string data = row[1].ToString();
                records.Add(new DataRecord { Id = id, Data = data });
            }

            return records;
        }
    }
}

// NoSQLAdapter.cs
namespace AdapterMethodClass
{
    public class NoSQLAdapter : IDataSource
    {
        private readonly NoSQLDatabase _noSqlDb;

        public NoSQLAdapter(NoSQLDatabase noSqlDb)
        {
            _noSqlDb = noSqlDb;
        }

        public List<DataRecord> GetData()
        {
            var documents = _noSqlDb.FetchDocuments();
            var records = new List<DataRecord>();

            foreach (var doc in documents)
            {
                int id = Convert.ToInt32(doc["_id"]);
                string data = doc["content"].ToString();
                records.Add(new DataRecord { Id = id, Data = data });
            }

            return records;
        }
    }
}

// XMLAdapter.cs
namespace AdapterMethodClass
{
    public class XMLAdapter : IDataSource
    {
        private readonly XMLDatabase _xmlDb;

        public XMLAdapter(XMLDatabase xmlDb)
        {
            _xmlDb = xmlDb;
        }

        public List<DataRecord> GetData()
        {
            var nodes = _xmlDb.ReadXML();
            var records = new List<DataRecord>();

            foreach (var node in nodes)
            {
                records.Add(new DataRecord { Id = node.Id, Data = node.Value });
            }

            return records;
        }
    }
}