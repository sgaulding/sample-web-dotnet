namespace TokenEx.Library.NetStandard.Models.P2PEService
{
    public class P2PETokenizeRequest : RequestBase
    {
        public string EncryptedTrack { get; set; }

        public string EncryptedProfile { get; set; }

        public string KSN { get; set; }

        public RequestFormatType RequestFormatType { get; set; }
    }
}
