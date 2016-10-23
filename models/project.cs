using MongoDB.Bson;

public class Project
{
    public int proj_id { get; set; }
    public string name { get; set; }
    public int budget { get; set; }
    public int allocatedHours { get; set; }
    public BsonDocument address { get; set; }
    public BsonDocument headquarter { get; set; }
}