using AutoMapper;
using Core.Business;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Services.Controllers
{
    public class AccountController : ApiController
    {
        public User GetLogin(string username, string password)
        {
            Core.DataContracts.LoginResponse loginResponse = Account.Login(username, password);
            return Mapper.Map<User>(loginResponse.User);
        }

        [HttpPost]
        public bool Post(User user)
        {
            Core.DataContracts.AuthenticationResponse authResponse = Account.CreateUser(Mapper.Map<Core.DataContracts.User>(user));
            return (authResponse.Code == Core.DataContracts.ResponseCode.Created);
        }
    }
}
