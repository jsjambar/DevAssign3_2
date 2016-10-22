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
            // employees object
            Employees employee = new Employees(1000);
            // connect to the database and empty the collections
            db.refresh();
            employee.createEmployees();

            /*Project test2 = new Project();
            test2.name = "Projectje";
            test2.budget = 2000;
            test2.allocatedHours = 13;*/
            //db.insertProject(test2);
        }
    }
}