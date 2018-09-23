namespace TokenEx.Library.NetStandard.Models.IFrame
{

    public class SessionIFrameRequest : RequestBase
    {
        public string HMACKey { get; set; }

        public TokenSchemeType TokenScheme { get; set; }

        public string OriginURL { get; set; }

        public string CustomerDefinedRefNumber { get; set; }

        public string CSS { get; set; }

        public string Placeholder { get; set; }

        public bool PCI { get; set; }
    }
}