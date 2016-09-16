using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenExWebDemo.DTO
{
    public class BaseRequest
    {
        public string APIKey { get; set; }
        public string TokenExID { get; set; }
    }
}