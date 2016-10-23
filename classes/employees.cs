using System;
using MongoDB.Bson;

class Employees
{
    int max;
    Random key;

    // counter for the id
    int counter = 1;
    
    public Employees(int max, Random key) {
        this.max = max;
        this.key = key;
    }
    Database db = new Database();
    public void createEmployees()   {

        Helpers helper = new Helpers(key);

        for(int i=0; i <= max; i++){

            Employee newEmployee = new Employee();
            newEmployee.bsn = counter;
            newEmployee.firstName = helper.getFirstName();
            newEmployee.lastName = helper.getLastName();
            newEmployee.addresses = new BsonDocument
            {
                {"country", helper.getCountry()},
                {"city", helper.getCity()},
                {"street", helper.getStreet()},
                {"number", helper.getRandomNr(1,30)},
                {"postalcode", helper.getPC()}    
            };
            newEmployee.positions = new BsonDocument
            {
                {"name", helper.getPositionName()},
                {"description", helper.getPositionDescription()},
                {"salary", helper.getRandomNr(2000,6000)}
            };
            newEmployee.degrees = new BsonDocument
            {
                {"course", helper.getCourse()},
                {"school", helper.getSchool()},
                {"level", helper.getLevel()}
            };
            newEmployee.headquarter = new BsonDocument
            {
                {"name", helper.getHQ()},
                {"rooms", helper.getRandomNr(1,10)},
                {"rent", helper.getRandomNr(300,800)}
            };
            newEmployee.projects = new BsonDocument
            {
                {"proj_id", helper.getRandomNr(1,100)},
                {"budget", helper.getRandomNr(1000,6000)},
                {"hours", helper.getRandomNr(10,120)},
                {"positions", new BsonDocument {
                  {"name", helper.getPositionName()},
                  {"description", helper.getPositionDescription()},
                  {"salary", helper.getRandomNr(2000,6000)},  
                }}
            };

            counter++;
            db.insertEmployee(newEmployee);
        }
    } 
}