using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Models;

namespace Diplom.Repository
{
    class MongoRepositoryImplementers
    {
        public static void Add(Implementer implementer)
        {
            var collection = MongoConnection.MongoCollectionImplementers;
            collection.Insert(implementer);
        }

        public static List<Implementer> GetAll()
        {
            var collection = MongoConnection.MongoCollectionImplementers;
            var result = collection.FindAll().ToList();
            return result;
        }
    }
}
