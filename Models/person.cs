using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace mongoexample.Services;

public class person
{   
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id{get; set;}

    public string firstName {get; set;} = null;

    public string lastname {get; set;} = null;

    public string email {get; set;} = null;

    public string marketingConsent {get; set;} = false;

}