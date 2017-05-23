using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Models;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Diplom.Repository
{
    class MongoRepositoryPeople
    {
        public static void Upsert(People people)
        {
            var collection = MongoConnection.MongoCollectionPeople;
            var query = Query<People>.EQ(a => a.Id, people.Id);
            var update = Update.Replace(people);
            collection.Update(query, update, UpdateFlags.Upsert);
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionPeople;
            var query = Query<Address>.EQ(a => a.Id, id);
            collection.Remove(query);
        }

        public static People Get(Guid id)
        {
            var collection = MongoConnection.MongoCollectionPeople;
            var query = Query<People>.EQ(a => a.Id, id);
            var result = collection.FindOne(query);
            return result;
        }

        public static List<People> GetByAddressId(Guid addressId)
        {
            var collection = MongoConnection.MongoCollectionPeople;
            var query = Query<People>.EQ(a => a.AddressId, addressId);
            var result = collection.Find(query).ToList();
            return result;
        }

        public static void RemoveByAddressId(Guid addressId)
        {
            var collection = MongoConnection.MongoCollectionPeople;
            var query = Query<People>.EQ(a => a.AddressId, addressId);
            collection.Remove(query);
        }

        public static List<People> GetAll()
        {
            var collection = MongoConnection.MongoCollectionPeople;
            var result = collection.FindAll().ToList();
            return result;
        }
    }
}
