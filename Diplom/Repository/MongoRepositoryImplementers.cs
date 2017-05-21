using System;
using System.Collections.Generic;
using System.Linq;
using Diplom.Models;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Diplom.Repository
{
    class MongoRepositoryImplementers
    {
        public static void Upsert(Implementer implementer)
        {
            var collection = MongoConnection.MongoCollectionImplementers;
            var query = Query<Implementer>.EQ(a => a.Id, implementer.Id);
            var update = Update.Replace(implementer);
            collection.Update(query, update, UpdateFlags.Upsert);
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionImplementers;
            var query = Query<Implementer>.EQ(a => a.Id, id);
            collection.Remove(query);
        }

        public static Implementer Get(Guid id)
        {
            var collection = MongoConnection.MongoCollectionImplementers;
            var query = Query<Implementer>.EQ(a => a.Id, id);
            return collection.FindOne(query);
        }

        public static List<Implementer> GetAll()
        {
            var collection = MongoConnection.MongoCollectionImplementers;
            var result = collection.FindAll().ToList();
            return result;
        }
    }
}
