using MongoDB.Bson;

class Employees
{
    int max;

    // counters for the loop
    int counter = 1;

    public Employees(int max) {
        this.max = max;
    }
    Database db = new Database();
    public void createEmployees()   {

        for(int i=0; i <= max; i++){

            Employee newEmployee = new Employee();
            newEmployee.bsn = counter;
            newEmployee.firstName = Helpers.generateString(10);
            newEmployee.lastName = Helpers.generateString(18);
            newEmployee.addresses = new BsonDocument
            {
                {"country", Helpers.generateString(10)},
                {"city", Helpers.generateString(10)},
                {"street", Helpers.generateString(20)},
                {"number", Helpers.generateNumber(1)},
                {"postalcode", Helpers.generatePC()}    
            };
            newEmployee.positions = new BsonDocument
            {
                {"name", Helpers.generateString(10)},
                {"description", Helpers.generateString(20)},
                {"salary", Helpers.generateSalary()}
            };
            newEmployee.degrees = new BsonDocument
            {
                {"course", Helpers.generateString(15)},
                {"school", Helpers.generateString(12)},
                {"level", Helpers.generateDegree()}
            };
            newEmployee.headquarter = new BsonDocument
            {
                {"name", Helpers.generateString(12)},
                {"rooms", Helpers.generateNumber(2)},
                {"rent", Helpers.generateRent()}
            };

            counter++;
            db.insertEmployee(newEmployee);
        }
    } 
}