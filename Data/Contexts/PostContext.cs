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
    public class PostContext : DbContext, ICollectionContext<Post>
    {
        static IQueryable<Post> queryablePost;
        static MongoCollection collection;

        public PostContext()
        {
            collection = database.GetCollection<Post>("Posts");
            queryablePost = collection.AsQueryable<Post>();
        }

        public IEnumerable<Post> GetAll()
        {
            return queryablePost.AsEnumerable();
        }

        public Post Get(string username)
        {
            //    var user = queryablePost.FirstOrDefault(u => u.Username == username);
            //    return user;
            throw new NotImplementedException("ToDo");
        }

        public bool Create(Post post)
        {
            bool isSuccess = false;

            IMongoQuery query = Query.EQ("title", post.Title);
            var exists = collection.FindAs<Post>(query);
            if (exists.ToList().Count == 0)
            {
                var result = collection.Save<Post>(post);
                isSuccess = result.Ok;
            }

            return isSuccess;
        }

        public bool Delete(string username)
        {
            throw new NotImplementedException("ToDo");
        }

        public bool Delete(ObjectId id)
        {
            bool isSuccess = false;

            IMongoQuery query = Query.EQ("_id", id);
            var exists = collection.FindAs<Post>(query);
            if (exists.ToList().Count == 1)
            {
                var result = collection.Remove(query);
                isSuccess = result.Ok;
            }

            return isSuccess;
        }

        public bool Update(Post post)
        {
            bool isSuccess = false;
            IMongoQuery query = Query.EQ("_id", post.Id);
            var exists = collection.FindAs<Post>(query);
            if (exists.ToList().Count == 1)
            {
                var result = collection.Save<Post>(post);
                isSuccess = result.Ok;
            }

            return isSuccess;
        }
    }
}