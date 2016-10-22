using System;
using MongoDB.Bson;

class Projects {
    int max;
    Random key;
    public Projects(int max, Random key) {
        this.max = max;
        this.key = key;
    }

    public void createProjects(){

        Database db = new Database();
        Helpers helper = new Helpers(key);
        

        for(int i=0; i <= max; i++){
            Project newProject = new Project();
            newProject.name = helper.getProjectName();
            newProject.budget = helper.getBudget();
            newProject.allocatedHours = helper.getHours();
            newProject.address = new BsonDocument
            {
                {"country", helper.getCountry()},
                {"city", helper.getCity()},
                {"street", helper.getStreet()},
                {"number", helper.getStreetNr()},
                {"postalcode", helper.getPC()}    
            };
            newProject.headquarter = new BsonDocument
            {
                {"name", helper.getHQ()},
                {"rooms", helper.getRooms()},
                {"rent", helper.getRent()}
            };

            db.insertProject(newProject);
        }
    }
}