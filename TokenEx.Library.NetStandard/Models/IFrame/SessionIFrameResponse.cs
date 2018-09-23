namespace TokenEx.Library.NetStandard.Models.IFrame
{
    public class SessionIFrameResponse : RequestBase
    {
        public string HTPURL { get; set; }

        public string SessionID { get; set; }
    }
}