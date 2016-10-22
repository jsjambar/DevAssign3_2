using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        static void Main(string[] args)
        {
            // connect to the database and empty the collections
            refresh();

            Employee test = new Employee();
            test.bsn = 12345;
            test.firstName = "Voornaam";
            test.lastName = "Achternaam";
            test.addresses = new BsonDocument
            {
                {"country", "Nederland"},
                {"city", "Rotterdam"},
                {"street", "Wijnhaven"},
                {"number", 7},
                {"postalcode", "3012AB"}    
            };
            test.positions = new BsonDocument
            {
                {"name", "dev"},
                {"description", "developer"},
                {"salary", 50}
            };
            test.degrees = new BsonDocument
            {
                {"course", "Leuk doen"},
                {"school", "HRO"},
                {"level", "PHD"}
            };
            test.headquarter = new BsonDocument
            {
                {"name", "Gebouwnaam"},
                {"rooms", 20},
                {"rent", 1000}
            };

            /*Project test2 = new Project();
            test2.name = "Projectje";
            test2.budget = 2000;
            test2.allocatedHours = 13;*/

            insertEmployee(test);
            //insertProject(test2);
        }

        public static void refresh()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("assign2");

            _database.DropCollectionAsync("employees");
            //_database.DropCollectionAsync("projects");
        }

        public static void insertEmployee(Employee employee)
        {
            var collection = _database.GetCollection<Employee>("employees");
            collection.InsertOne(employee);
        }

        public static void insertProject(Project project)
        {
            var collection = _database.GetCollection<Project>("projects");
            collection.InsertOne(project);
        }
    }
}