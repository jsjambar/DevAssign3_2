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
                {"number", helper.getStreetNr()},
                {"postalcode", helper.getPC()}    
            };
            newEmployee.positions = new BsonDocument
            {
                {"name", helper.getPositionName()},
                {"description", helper.getPositionDescription()},
                {"salary", helper.getSalary()}
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
                {"rooms", helper.getRooms()},
                {"rent", helper.getRent()}
            };

            counter++;
            db.insertEmployee(newEmployee);
        }
    } 
}