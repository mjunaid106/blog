using Core.Contexts;
using Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public class Account
    {
        static UserContext userContext;

        static Account()
        {
            userContext = new UserContext();
        }

        public static LoginResponse Login(string username, string password)
        {
            var loginResponse = new LoginResponse();

            User user = userContext.Get(username);

            if (user == null)
            {
                loginResponse.Code = ResponseCode.NotFound;
            }
            else
            {
                if (user.Password.Equals(password))
                {
                    loginResponse.Code = ResponseCode.Found;
                    loginResponse.User = user;
                }
                else
                {
                    loginResponse.Code = ResponseCode.InvalidPassword;
                }
            }

            return loginResponse;
        }

        public static AuthenticationResponse CreateUser(User user)
        {
            var authResponse = new AuthenticationResponse(ResponseType.Create) { Code = ResponseCode.Error, User = null };

            bool isUserCreated = userContext.Create(user);

            if (isUserCreated)
            {
                authResponse.Code = ResponseCode.Created;
                authResponse.User = user;

            }

            return authResponse;
        }
    }
}
