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


namespace Core.Contexts.Test
{
    [TestClass]
    public class UserContextTest
    {
        ICollectionContext<User> userContext;

        public UserContextTest()
        {
            userContext = new UserContext();
        }

        [TestMethod]
        public void GetAllUsers()
        {
            IEnumerable<User> users = userContext.GetAll();
            Assert.AreEqual(1, users.Count());
        }

        [TestMethod]
        public void GetUser()
        {
            User user = userContext.Get("bob");
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void CreateUser()
        {
            var user = new User("john") { FirstName = "John", LastName = "Smith", Password = "password" };
            bool result = userContext.Create(user);
            Assert.IsTrue(result);
            Assert.IsNotNull(user.Id);
        }

        [TestMethod]
        public void UpdateUser()
        {
            var user = new User("bob") { Id = new ObjectId("5409dc09850947cb64ad4e7c"), FirstName = "Bob", LastName = "Builder", Password = "password" };
            bool result = userContext.Update(user);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteUser()
        {
            bool result = userContext.Delete("john");
            Assert.IsTrue(result);
        }
    }
}
