namespace TokenEx.Library.NetStandard.Models.PaymentService
{
    public interface ITransactionRequest
    {
        GatewayBase Gateway { get; set; }


    }
}