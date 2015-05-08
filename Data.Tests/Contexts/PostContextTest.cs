using Core.Contexts;
using Core.DataContracts;
using Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests.Contexts
{
    [TestClass]
    public class PostContextTest
    {
        ICollectionContext<Post> postContext;

        public PostContextTest()
        {
            postContext = new PostContext();
        }

        [TestMethod]
        public void GetAllPosts()
        {
            IEnumerable<Post> post = postContext.GetAll();
            Assert.AreNotEqual(0, post.Count());
        }

        //[TestMethod]
        //public void GetUser()
        //{
        //    Post post = postContext.Get("bob");
        //    Assert.IsNotNull(post);
        //}

        [TestMethod]
        public void CreatePosts()
        {
            var post = new Post
            {
                Title = "Second Blog",
                Text = "This is a second blog added from unit",
                PostedOn = DateTime.Now.AddHours(-1),
                LastModified = DateTime.Now
            };
            bool result = postContext.Create(post);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdatePost()
        {
            var user = new Post
            {
                Id = new ObjectId("54119baeba39ab13045a993d"),
                Title = "Second Blog",
                Text = "Updated Text",
                PostedOn = DateTime.Now.AddHours(-1),
                LastModified = DateTime.Now
            };
            bool result = postContext.Update(user);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeletePost()
        {
            bool result = postContext.Delete(new ObjectId("54119baeba39ab13045a993d"));
            Assert.IsTrue(result);
        }
    }
}
