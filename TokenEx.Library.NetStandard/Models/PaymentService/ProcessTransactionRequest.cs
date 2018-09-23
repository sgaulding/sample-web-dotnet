namespace TokenEx.Library.NetStandard.Models.PaymentService
{
    public class ProcessTransactionRequest : RequestBase
    {
        public TransactionType TransactionType { get; set; }

        public ITransactionRequest TransactionRequest { get; set; }
    }
}