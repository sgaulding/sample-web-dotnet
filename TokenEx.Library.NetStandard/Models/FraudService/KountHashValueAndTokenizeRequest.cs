namespace TokenEx.Library.NetStandard.Models.FraudService
{
    public class KountHashValueAndTokenizeRequest : RequestBase
    {
        public string Data { get; set; }

        public bool Encrypted { get; set; }

        public TokenSchemeType TokenScheme { get; set; }
    }
}