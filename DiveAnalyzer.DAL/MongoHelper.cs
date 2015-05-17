using MongoDB.Driver;

namespace DiveAnalyzer.DAL
{
    public static class MongoHelper
    {
        //private const string connectionString = "mongodb://diveAnalyzerAdmin:unlockme@192.168.9.201/DiveAnalyzer";
        private const string connectionString = "mongodb://192.168.9.201:27017/DiveLogAnalyzer";
        private const string databaseName = "DiveAnalyzer";
        private const string collectionName = "Dive";

        private static MongoClient MongoClient
        {
            get
            {
                return new MongoClient(connectionString);
            }
        }
        private static IMongoDatabase MongoDatabase
        {
            get
            {
                return MongoClient.GetDatabase(databaseName);
            }
        }

        public static IMongoCollection<Entities.Dive> MongoCollection
        {
            get
            {
                return MongoDatabase.GetCollection<Entities.Dive>(collectionName);
            }
        }
    }
}
