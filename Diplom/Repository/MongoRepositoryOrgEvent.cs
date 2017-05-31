using System;
using System.Collections.Generic;
using System.Linq;
using Diplom.Models;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Diplom.Repository
{
    public static class MongoRepositoryOrgEvent
    {
        public static void Upsert(OrgEvent orgEvent)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var query = Query<OrgEvent>.EQ(a => a.Id, orgEvent.Id);
            var update = Update.Replace(orgEvent);
            collection.Update(query, update, UpdateFlags.Upsert);
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var query = Query<OrgEvent>.EQ(a => a.Id, id);
            collection.Remove(query);
        }


        public static List<OrgEvent> GetAll()
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var result = collection.FindAll().ToList();
            return result;
        }

        public static OrgEvent Get(Guid id)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var query = Query<OrgEvent>.EQ(a => a.Id, id);
            var result = collection.FindOne(query);
            return result;
        }

        public static List<OrgEvent> GetByDate(long startDate, long endDate, List<EventType> eventTypeList)
        {
            var collection = MongoConnection.MongoCollectionOrgEvents;
            var query = Query.And(
                Query<OrgEvent>.GTE(a => a.DateTime, startDate),
                Query<OrgEvent>.LTE(a => a.DateTime, endDate),
                Query<OrgEvent>.In(a => a.EventType, eventTypeList)
            );
            var result = collection.Find(query).ToList();
            return result;
        }
    }
}
