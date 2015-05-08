using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Contexts
{
    public class DbContext
    {
        readonly string connectionString;
        private MongoClient client;
        private MongoServer server;
        protected MongoDatabase database;

        public DbContext()
        {
            //connectionString = System.Web.Configuration.WebConfigurationManager.AppSettings[0];
            connectionString = "mongodb://localhost:27017";
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("blogdb");
        }
    }
}
