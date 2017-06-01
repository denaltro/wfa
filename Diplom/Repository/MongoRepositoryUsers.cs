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
    public class MongoRepositoryUsers
    {
        public static User Login(string name, string password)
        {
            var collection = MongoConnection.MongoCollectionUsers;
            var query = Query.And(Query<User>.EQ(a => a.Name, name), Query<User>.EQ(a => a.Password, password));
            var result = collection.FindOne(query);
            return result;
        }

        public static void Upsert(User user)
        {
            var collection = MongoConnection.MongoCollectionUsers;
            var query = Query<User>.EQ(a => a.Id, user.Id);
            var update = Update.Replace(user);
            collection.Update(query, update, UpdateFlags.Upsert);
        }

        public static List<User> GetAll(bool? isAdmin = null)
        {
            var collection = MongoConnection.MongoCollectionUsers;
            List<User> result;
            if (isAdmin == null)
            {
                result = collection.FindAll().ToList();
            }
            else
            {
                var query = Query<User>.EQ(a => a.IsAdmin, isAdmin);
                result = collection.Find(query).ToList();
            }
            return result;
        }

        public static void Remove(Guid id)
        {
            var collection = MongoConnection.MongoCollectionUsers;
            var query = Query<User>.EQ(a => a.Id, id);
            var update = Update.SetWrapped("IsDeleted", true);
            collection.Update(query, update);
            collection.Update(query, update);
        }

        public static User Get(Guid id)
        {
            var collection = MongoConnection.MongoCollectionUsers;
            var query = Query<User>.EQ(a => a.Id, id);
            var result = collection.FindOne(query);
            return result;
        }
    }
}
