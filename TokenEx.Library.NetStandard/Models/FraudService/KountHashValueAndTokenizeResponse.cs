namespace TokenEx.Library.NetStandard.Models.FraudService
{
    public class KountHashValueAndTokenizeResponse : ResponseBase
    {
        public string Token { get; set; }

        public string Hash { get; set; }
    }
}