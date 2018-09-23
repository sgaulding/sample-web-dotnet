namespace TokenEx.Library.NetStandard.Models.TokenService
{
    public class TokenizeRequest : RequestBase
    {
        public string Data { get; set; }

        public TokenSchemeType TokenScheme { get; set; }
    }
}