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
            // employees object - 10000 employees
            Employees employee = new Employees(10000);
            // project object - 1000 projects
            Projects project = new Projects(1000);
            // connect to the database and empty the collections
            db.refresh();
            // Add all random generated employees
            //employee.createEmployees();
            // Add all random generated projects
            project.createProjects();
        }
    }
}