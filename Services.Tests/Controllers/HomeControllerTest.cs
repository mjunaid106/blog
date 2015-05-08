using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Controllers;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Tests
{
    [TestClass]
    public class HomeControllerTest : TestBase
    {
        [TestMethod]
        [TestCategory("HomeControllerTest")]
        public void GetAllPosts()
        {
            var home = new BlogController();
            User user = new User("bob");
            var startDate = new DateTime(2013, 1, 1);
            var endDate = new DateTime(2014, 1, 1);
            IEnumerable<Post> posts = home.GetAllPosts(user);
            Assert.AreEqual(2, posts.Count());
        }

        [TestMethod]
        [TestCategory("HomeControllerTest")]
        public void GetPosts()
        {
            var home = new BlogController();
            User user = new User("bob");
            var startDate = new DateTime(2013, 1, 1);
            var endDate = new DateTime(2014, 1, 1);
            IEnumerable<Post> posts = home.GetPosts(user, startDate, endDate);
            Assert.AreEqual(2, posts.Count());
        }

    }
}
