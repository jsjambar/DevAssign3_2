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
        static void Main(string[] args)
        {
            // database object
            Database db = new Database();
            // connect to the database and empty the collections
            db.refresh();

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

            db.insertEmployee(test);
            //db.insertProject(test2);
        }
    }
}