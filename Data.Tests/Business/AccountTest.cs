using Core.Business;
using Core.DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        [TestCategory("Login")]
        public void LoginWithValidUser()
        {
            LoginResponse loginResponse = Account.Login("bob", "password");
            Assert.AreEqual(ResponseCode.Found, loginResponse.Code);
            Assert.AreEqual("bob", loginResponse.User.Username);
        }

        [TestMethod]
        [TestCategory("Login")]
        public void LoginWithValidUser_InvalidPassword()
        {
            var account = new Account();
            LoginResponse loginResponse = Account.Login("bob", "password1");
            Assert.AreEqual(ResponseCode.InvalidPassword, loginResponse.Code);
            Assert.IsNull(loginResponse.User);
        }

        [TestMethod]
        [TestCategory("Login")]
        public void LoginWithInvalidUser()
        {
            var account = new Account();
            LoginResponse loginResponse = Account.Login("bob1", "password");
            Assert.AreEqual(ResponseCode.NotFound, loginResponse.Code);
            Assert.IsNull(loginResponse.User);
        }

        [TestMethod]
        [TestCategory("Create")]
        public void CreateUser_NewUser_Success()
        {
            var account = new Account();
            var user = new User("john") { FirstName = "John", LastName = "Smith", Password = "password" };
            AuthenticationResponse authResponse = Account.CreateUser(user);
            Assert.AreEqual(ResponseType.Create, authResponse.Type);
            Assert.AreEqual(ResponseCode.Created, authResponse.Code);
            Assert.IsNotNull(authResponse.User);
            Assert.IsNotNull(authResponse.User.Id);
        }

        [TestMethod]
        [TestCategory("Create")]
        public void CreateUser_UserAlreadyExists_Failure()
        {
            var account = new Account();
            var user = new User("john") { FirstName = "John", LastName = "Smith", Password = "password" };
            AuthenticationResponse authResponse = Account.CreateUser(user);
            Assert.AreEqual(ResponseType.Create, authResponse.Type);
            Assert.AreEqual(ResponseCode.Error, authResponse.Code);
            Assert.IsNull(authResponse.User);
        }
    }
}
