using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace PerfectLifeWebService.Model
{
    public class WeightRecord
    {
        public WeightRecord(string userName, int weight)
        {
            UserName = userName;
            Weight = weight;
            DateTime = DateTime.UtcNow;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string UserName { get; private set; }
        public int Weight { get; private set; }
        public DateTime DateTime { get; private set; }
    }
}