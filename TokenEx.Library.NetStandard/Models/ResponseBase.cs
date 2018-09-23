namespace TokenEx.Library.NetStandard.Models
{
    public class ResponseBase
    {
        public bool Success { get; set; }

        public string ReferenceNumber { get; set; }

        public string Error { get; set; }
    }
}