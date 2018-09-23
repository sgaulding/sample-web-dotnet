namespace TokenEx.Library.NetStandard.Models.PaymentService.Gateway
{
    public class AuthorizeNetGateway : GatewayBase, IGatewayLoginPass
    {
        public override string Name { get; } = "AuthorizeNetGateway";

        public string Login { get; set; }

        public string Password { get; set; }
    }

    public interface IGatewayLoginPass
    {
        string Login { get; set; }

        string Password { get; set; }
    }
}