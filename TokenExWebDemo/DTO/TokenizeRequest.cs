using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenExWebDemo.DTO
{
    public class TokenizeRequest : BaseRequest
    {
            public string EcryptedData { get; set; }
            public int TokenScheme { get; set; }

    }
}