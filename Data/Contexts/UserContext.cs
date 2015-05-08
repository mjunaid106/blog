using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using Core.DataContracts;
using Core.Interfaces;

namespace Core.Contexts
{
    public class UserContext : DbContext, ICollectionContext<User>
    {
        static IQueryable<User> queryableUser;
        static MongoCollection collection;

        public UserContext()
        {
            collection = database.GetCollection<User>("Users");
            queryableUser = collection.AsQueryable<User>();
        }

        public IEnumerable<User> GetAll()
        {
            return queryableUser.AsEnumerable();
        }

        public User Get(string username)
        {
            var user = queryableUser.FirstOrDefault(u => u.Username == username);
            return user;
        }

        public bool Create(User user)
        {
            bool isSuccess = false;

            IMongoQuery query = Query.EQ("username", user.Username);
            var exists = collection.FindAs<User>(query);
            if (exists.ToList().Count == 0)
            {
                var result = collection.Save<User>(user);
                isSuccess = result.Ok;
            }

            return isSuccess;
        }

        public bool Delete(string username)
        {
            bool isSuccess = false;

            IMongoQuery query = Query.EQ("username", username);
            var exists = collection.FindAs<User>(query);
            if (exists.ToList().Count == 1)
            {
                var result = collection.Remove(query);
                isSuccess = result.Ok;
            }

            return isSuccess;
        }

        public bool Delete(ObjectId id)
        {
            throw new NotImplementedException("ToDo");
        }

        public bool Update(User user)
        {
            bool isSuccess = false;
            IMongoQuery query = Query.EQ("username", user.Username);
            var exists = collection.FindAs<User>(query);
            if (exists.ToList().Count == 1)
            {
                var result = collection.Save<User>(user);
                isSuccess = result.Ok;
            }

            return isSuccess;
        }

    }
}