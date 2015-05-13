using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DiveAnalyzer.DAL
{
    public static class DAL
    {
        public static void InsertDive(Entities.Dive dive)
        {
            if (Exists(dive))
            {
                return;
            }

            MongoHelper.MongoCollection.InsertOneAsync(dive);
        }
        static bool Exists(Entities.Dive dive)
        {
            return AsyncExists(dive).Result;
        }

        async static Task<Entities.Dive> AsyncFindDive(Entities.Dive dive)
        {
            var builder = Builders<Entities.Dive>.Filter;

            var diveFilterDefinition =
                builder.Eq("Identifier", dive.Identifier);

            var result = await MongoHelper.MongoCollection.Find(diveFilterDefinition).ToListAsync();
            return result.SingleOrDefault();
        }

        async static Task<bool> AsyncExists(Entities.Dive dive)
        {
            var result = await AsyncFindDive(dive);
            return result != null;
        }
        public static List<Entities.Dive> GetDives()
        {
            return AsyncGetDives().Result.ToList();
        }

        public async static Task<IEnumerable<Entities.Dive>> AsyncGetDives()
        {
            var result = await MongoHelper.MongoCollection.Find(d => true).ToListAsync();
            return result;
        }
    }
}
