using System;
using System.Collections.Generic;
using System.Linq;
using Diplom.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Diplom.Repository
{
    class MongoRepositoryController
    {

        public static void Upsert(Controller controller)
        {
            var collection = MongoConnection.MongoCollectionController;
            var query = Query<Controller>.EQ(a => a.Id, controller.Id);
            var update = Update.Replace(controller);
            collection.Update(query, update, UpdateFlags.Upsert);
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionController;
            var query = Query<Controller>.EQ(a => a.Id, id);
            collection.Remove(query);
        }

        public static Controller Get(Guid id)
        {
            var collection = MongoConnection.MongoCollectionController;
            var query = Query<Controller>.EQ(a => a.Id, id);
            var result = collection.FindOne(query);
            return result;
        }

        public static List<Controller> GetAll()
        {
            var collection = MongoConnection.MongoCollectionController;
            var result = collection.FindAll().ToList();
            return result;
        }
    }
}
