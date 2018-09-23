namespace TokenEx.Library.NetStandard.Models
{
    public abstract class RequestBase
    {
        public string APIKey { get; set; }

        public string TokenExID { get; set; }
    }
}