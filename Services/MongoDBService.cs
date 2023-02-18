using mongoexample.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;


namespace mongoexample.Servise;

public class MongoDBService
{
    private readonly IMongoCollection<person> people_Collections;

    public MongoDBService(IOptions<MongoDBSettings> MongoDBSettings){
        IMongoCDatabase database = client.GetDatabase(MongoDBSettings.Value.DatabaseName);
        people_Collections = database = database.GetCollection<person>(MongoDBSettings.Value.CollectionName);
        
    }
}