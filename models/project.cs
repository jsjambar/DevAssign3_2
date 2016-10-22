using MongoDB.Bson;

public class Project
{
    public ObjectId _id { get; set; }
    public string name { get; set; }
    public int budget { get; set; }
    public int allocatedHours { get; set; }
}