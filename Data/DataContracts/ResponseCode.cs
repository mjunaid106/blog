using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataContracts
{
    public enum ResponseCode
    {
        NotFound,
        Found,
        InvalidPassword,
        Created,
        Error
    }
}
