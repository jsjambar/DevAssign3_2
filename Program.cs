﻿using MongoDB.Driver;
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
            Random key = new Random(1);
            string seed = "xd69";

            // database object
            Database db = new Database();
            // employees object - x employees
            Employees employee = new Employees(10000, key);
            // project object - x projects
            Projects project = new Projects(100, key);
            // connect to the database and empty the collections
            db.refresh();
            // Add all random generated employees
            employee.createEmployees();
            // Add all random generated projects
            project.createProjects();

            Console.WriteLine("Our seed is: "+seed);
        }
    }
}