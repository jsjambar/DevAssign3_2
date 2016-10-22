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
            // connect
            connect();
            
            Employee test = new Employee();
            test.firstName = "Ja";
            test.lastName = "Nee";

            Project test2 = new Project();
            test2.name = "Projectje";
            test2.budget = 2000;
            test2.allocatedHours = 13;

            insertEmployee(test);
            insertProject(test2);
        }

        public static void connect()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("assign2");
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