namespace TokenEx.Library.NetStandard.Models.PaymentService
{
    public class ProcessTransactionResponse : ResponseBase
    {
        public string Authorization { get; set; }

        public string Message { get; set; }

        public string AVSResult { get; set; }

        public string CVVResult { get; set; }

        public string Params { get; set; }

        public bool TransactionResult { get; set; }
    }
}