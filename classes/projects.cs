using System;
using MongoDB.Bson;

class Projects {
    int max;
    Random key;
    // counter for the id
    int counter = 1;
    public Projects(int max, Random key) {
        this.max = max;
        this.key = key;
    }

    public void createProjects(){

        Database db = new Database();
        Helpers helper = new Helpers(key);
        

        for(int i=0; i <= max; i++){
            Project newProject = new Project();
            newProject.proj_id = counter;
            newProject.name = helper.getProjectName();
            newProject.budget = helper.getRandomNr(1000, 6000);
            newProject.allocatedHours = helper.getRandomNr(10,120);
            newProject.address = new BsonDocument
            {
                {"country", helper.getCountry()},
                {"city", helper.getCity()},
                {"street", helper.getStreet()},
                {"number", helper.getRandomNr(1,30)},
                {"postalcode", helper.getPC()}    
            };
            newProject.headquarter = new BsonDocument
            {
                {"name", helper.getHQ()},
                {"rooms", helper.getRandomNr(1,10)},
                {"rent", helper.getRandomNr(300,1000)}
            };

            counter++;
            db.insertProject(newProject);
        }
    }
}