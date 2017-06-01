using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Models;
using MongoDB.Driver;

namespace Diplom.Repository
{
    public class MongoConnection
    {
        public static MongoCollection<Address> MongoCollectionAddresses { get; set; }
        public static MongoCollection<Implementer> MongoCollectionImplementers { get; set; }
        public static MongoCollection<OrgEvent> MongoCollectionOrgEvents { get; set; }
        public static MongoCollection<People> MongoCollectionPeople { get; set; }
        public static MongoCollection<User> MongoCollectionUsers { get; set; }

        static MongoConnection()
        {
            var mongodbConnectionString = "mongodb://" + ConfigurationManager.AppSettings["mongo-server"];
            var client = new MongoClient(mongodbConnectionString);
#pragma warning disable
            MongoServer server = client.GetServer();
#pragma warning restore
            MongoDatabase database = server.GetDatabase(ConfigurationManager.AppSettings["mongo-database"]);

            MongoCollectionAddresses = database.GetCollection<Address>(ConfigurationManager.AppSettings["mongo-collection-addresses"]);
            MongoCollectionImplementers = database.GetCollection<Implementer>(ConfigurationManager.AppSettings["mongo-collection-implementers"]);
            MongoCollectionOrgEvents = database.GetCollection<OrgEvent>(ConfigurationManager.AppSettings["mongo-collection-orgevents"]);
            MongoCollectionPeople = database.GetCollection<People>(ConfigurationManager.AppSettings["mongo-collection-people"]);
            MongoCollectionUsers = database.GetCollection<User>(ConfigurationManager.AppSettings["mongo-collection-users"]);
        }
    }
}
