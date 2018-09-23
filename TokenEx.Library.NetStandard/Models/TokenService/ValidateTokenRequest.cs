namespace TokenEx.Library.NetStandard.Models.TokenService
{
    public class ValidateTokenRequest : RequestBase
    {
        public string Token { get; set; }
    }
}