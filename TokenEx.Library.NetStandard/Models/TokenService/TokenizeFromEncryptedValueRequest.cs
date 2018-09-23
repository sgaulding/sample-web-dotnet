namespace TokenEx.Library.NetStandard.Models.TokenService
{
    public class TokenizeFromEncryptedValueRequest : RequestBase
    {
        public string EncryptedData { get; set; }

        public TokenSchemeType TokenScheme { get; set; }
    }
}