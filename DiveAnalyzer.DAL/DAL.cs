using System;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DiveAnalyzer.DAL
{
    public static class DAL
    {
        const string connectionString = "mongodb://@192.168.99.100:32768/";
        public static void Test()
        {
            var client = new MongoClient(connectionString);

            //Use the MongoClient to access the server
           MongoDB.Driver.server MongoServer server = client.GetServer();

            // Use the server to access the 'test' database
            MongoDatabase database = server.GetDatabase("test");
        }
    }
}
