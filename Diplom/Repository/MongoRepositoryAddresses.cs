using System;
using System.Collections.Generic;
using System.Linq;
using Diplom.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Diplom.Repository
{
    class MongoRepositoryAddresses
    {
        public static void Upsert(Address address)
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var query = Query<Address>.EQ(a => a.Id, address.Id);
            var update = Update.Replace(address);
            collection.Update(query, update, UpdateFlags.Upsert);
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var query = Query<Address>.EQ(a => a.Id, id);
            collection.Remove(query);
        }

        public static Address Get(Guid id)
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var query = Query<Address>.EQ(a => a.Id, id);
            var result = collection.FindOne(query);
            return result;
        }

        public static List<Address> GetAll()
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var result = collection.FindAll().ToList();
            return result;
        }

        public static Address Get(string street, string house, string building, string apartment)
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var query = Query.And(
                Query<Address>.Matches(a => a.Street, new BsonRegularExpression(street, "i")),
                Query<Address>.EQ(a => a.House, house),
                Query<Address>.EQ(a => a.Building, building),
                Query<Address>.EQ(a => a.Apartment, apartment)
                );
            var result = collection.FindOne(query);
            return result;
        }

        public static List<Address> Get(List<Guid> ids)
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var query = Query<Address>.In(a => a.Id, ids);
            var result = collection.Find(query).ToList();
            return result;
        }
    }
}
