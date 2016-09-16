using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenExWebDemo.DTO
{
    public class BaseResponse
    {
        public string Error { get; set; }
        public string ReferenceNumber { get; set; }
        public bool Success { get; set; }
    }
}