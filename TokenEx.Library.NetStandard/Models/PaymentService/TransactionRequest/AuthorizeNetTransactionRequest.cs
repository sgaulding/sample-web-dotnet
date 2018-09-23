namespace TokenEx.Library.NetStandard.Models.PaymentService.TransactionRequest
{
    public class AuthorizeNetTransactionRequest : ITransactionRequest
    {
        public GatewayBase Gateway { get; set; }

    }
}