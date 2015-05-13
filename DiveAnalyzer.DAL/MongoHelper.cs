using MongoDB.Driver;

namespace DiveAnalyzer.DAL
{
    public static class MongoHelper
    {
        private const string connectionString = "mongodb://diveAnalyzerAdmin:unlockme@localhost/DiveAnalyzer";
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
