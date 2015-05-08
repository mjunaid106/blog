using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataContracts
{
    public class AuthenticationResponse
    {
        //private ResponseType responseType;

        public AuthenticationResponse(ResponseType responseType)
        {
            // TODO: Complete member initialization
            //this.responseType = responseType;
            this.Type = responseType;
        }
        public ResponseType Type { get; set; }
        public ResponseCode Code { get; set; }
        public User User { get; set; }
    }
}
