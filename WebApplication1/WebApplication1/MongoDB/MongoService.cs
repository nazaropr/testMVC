﻿using MongoDB.Driver;

namespace WebApplication1.MongoDB
{
    public class MongoService
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoDatabase _database;

        public MongoService(IConfiguration configuration)
        {
            _configuration = configuration;
            var connectionString = _configuration.GetConnectionString("DBConnection");
            var mongoUrl = MongoUrl.Create(connectionString);
            var mongoClient = new MongoClient(mongoUrl);
            _database = mongoClient.GetDatabase(mongoUrl.DatabaseName);
        }

        public IMongoDatabase? Database => _database; 
    }
}
