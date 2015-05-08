using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataContracts
{
    public class LoginResponse
    {
        public ResponseCode Code { get; set; }

        public User User { get; set; }
    }
}
