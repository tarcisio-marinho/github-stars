using System.IO;
using github_stars.Infra.Contracts;
using github_stars.Infra.mongodb;
using MongoDB.Driver;

namespace github_stars.Infra.Services
{
    public class Storage : IStorage
    {
        private IMongoClient client;
        private IMongoDatabase database;
        public Storage()
        {
            this.client = new MongoClient(URI.Uri);
            this.database = client.GetDatabase(URI.Collection);
        }

        public void Insert()
        {

        }

        public void Update()
        {

        }
    }
}