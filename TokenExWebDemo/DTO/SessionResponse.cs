using TokenExWebDemo.DTO;

namespace TokenExWebDemo.Controllers
{
    internal class SessionResponse : BaseResponse
    {
        public string HTPURL { get; set; }
        public string SessionID { get; set; }
    }
}