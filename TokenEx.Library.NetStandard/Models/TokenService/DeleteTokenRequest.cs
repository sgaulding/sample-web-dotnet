namespace TokenEx.Library.NetStandard.Models.TokenService
{
    public class DeleteTokenRequest : RequestBase
    {
        public string Token { get; set; }
    }
}