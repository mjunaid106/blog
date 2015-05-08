using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Controllers;
using Services.Models;

namespace Services.Tests
{
    [TestClass]
    public class AccountControllerTest : TestBase
    {
        [TestMethod]
        public void Login_Success()
        {
            var ac = new AccountController();
            User user = ac.GetLogin("bob", "password");
            Assert.AreEqual("Bob", user.FirstName);
        }

        [TestMethod]
        public void Login_WrongPassword()
        {
            var ac = new AccountController();
            User user = ac.GetLogin("bob", "password1");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void Login_InvalidUser()
        {
            var ac = new AccountController();
            User user = ac.GetLogin("bob1", "password");
            Assert.IsNull(user);
        }


        [TestMethod]
        public void Register_Success()
        {
            var ac = new AccountController();
            var user = new User("john") { FirstName = "John", LastName = "Smith", Password = "password" };
            bool isUserCreated = ac.Post(user);
            Assert.IsTrue(isUserCreated);
        }
    }
}
