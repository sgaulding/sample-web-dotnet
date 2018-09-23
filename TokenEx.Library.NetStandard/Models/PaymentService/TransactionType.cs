namespace TokenEx.Library.NetStandard.Models.PaymentService
{
    public enum TransactionType
    { 
        Authorize = 1,
        Capture = 2,
        Purchase = 3,
        Refund = 4,
        Void = 5,
        Reverse = 6
    }
}