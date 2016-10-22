using MongoDB.Driver;

class Database
{
    protected static IMongoClient _client;
    protected static IMongoDatabase _database;
    public void refresh()
    {
        _client = new MongoClient();
        _database = _client.GetDatabase("assign2");

        _database.DropCollectionAsync("employees");
        //_database.DropCollectionAsync("projects");
    }

    public void insertEmployee(Employee employee)
    {
        var collection = _database.GetCollection<Employee>("employees");
        collection.InsertOne(employee);
    }

    public void insertProject(Project project)
    {
        var collection = _database.GetCollection<Project>("projects");
        collection.InsertOne(project);
    }
}