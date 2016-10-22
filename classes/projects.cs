using MongoDB.Bson;

class Projects {
    int max;
    public Projects(int max) {
        this.max = max;
    }

    public void createProjects(){

        Database db = new Database();

        for(int i=0; i <= max; i++){

            Project newProject = new Project();
            newProject.name = Helpers.generateString(12);
            newProject.budget = Helpers.generateSalary();
            newProject.allocatedHours = Helpers.generateNumber(1);
            newProject.address = new BsonDocument
            {
                {"country", Helpers.generateString(10)},
                {"city", Helpers.generateString(10)},
                {"street", Helpers.generateString(20)},
                {"number", Helpers.generateNumber(1)},
                {"postalcode", Helpers.generatePC()}    
            };
            newProject.headquarter = new BsonDocument
            {
                {"name", Helpers.generateString(12)},
                {"rooms", Helpers.generateNumber(2)},
                {"rent", Helpers.generateRent()}
            };

            db.insertProject(newProject);
        }
    }
}