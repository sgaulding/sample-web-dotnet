using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenExWebDemo.DTO
{
    public class SessionRequest : BaseRequest
    {
        public string HMACKey { get; set; }
        public int TokenScheme { get; set; }
        public string OriginURL { get; set; }
        public string CustomerRefnumber { get; set; }
        public string CSS { get; set; }       

    }
}