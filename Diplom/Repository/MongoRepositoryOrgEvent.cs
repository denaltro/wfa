using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Models;
using MongoDB.Driver.Builders;

namespace Diplom.Repository
{
    public static class MongoRepositoryOrgEvent
    {
        public static void Add(OrgEvent orgEvent)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            collection.Insert(orgEvent);
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var query = Query<OrgEvent>.EQ(a => a.Id, id);
            collection.Remove(query);
        }

        public static void Update(OrgEvent orgEvent)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var query = Query<OrgEvent>.EQ(a => a.Id, orgEvent.Id);
            var update = Update<OrgEvent>.Replace(orgEvent);
            collection.Update(query, update);
        }

        public static List<OrgEvent> GetAll()
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var result = collection.FindAll().ToList();
            return result;
        }
    }
}
