using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;

namespace PerfectLifeWebService.Model
{
    public class WeightRecordMongoRepository : IWeightRecordRepository
    {
        IMongoDatabase _database;
        string collectionName = "weightRecords";

        public WeightRecordMongoRepository()
        {
            var client = new MongoClient(MongoUrl.Create($"mongodb://{Constants.MongoServer}:27017"));
            
            _database = client.GetDatabase("perfectlife");
        }

        public void AddRecord(WeightRecord record)
        {
            var document = new BsonDocument
            {
                {nameof(record.UserName), BsonValue.Create(record.UserName)},
                {nameof(record.Weight), BsonValue.Create(record.Weight)},
                {nameof(record.DateTime), BsonValue.Create(DateTime.UtcNow)},
            };

            var collection = _database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }

        public IEnumerable<WeightRecord> GetRecords(string userName)
        {
            var collection = _database.GetCollection<WeightRecord>(collectionName).AsQueryable();

            return collection.Where(x => x.UserName == userName);
        }

        public void DeleteRecords(string userName)
        {
            var collection = _database.GetCollection<WeightRecord>(collectionName);
            collection.DeleteMany(filter => filter.UserName == userName);
        }
    }
}
