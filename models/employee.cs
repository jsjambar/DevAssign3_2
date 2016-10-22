using MongoDB.Bson;

public class Employee
{
   public int bsn { get; set; }
   public string firstName { get; set; }
   public string lastName { get; set; }
   public BsonDocument addresses { get; set; }
   public BsonDocument positions { get; set; }
   public BsonDocument degrees { get; set; }
   public BsonDocument headquarter { get; set; }

}