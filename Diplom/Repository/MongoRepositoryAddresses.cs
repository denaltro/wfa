using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Models;

namespace Diplom.Repository
{
    class MongoRepositoryAddresses
    {
        public static void Add(Address address)
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            collection.Insert(address);
        }

        public static List<Address> GetAll()
        {
            var collection = MongoConnection.MongoCollectionAddresses;
            var result = collection.FindAll().ToList();
            return result;
        }
    }
}
