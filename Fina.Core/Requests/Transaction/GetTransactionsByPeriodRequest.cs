namespace Fina.Core.Requests.Transaction;

public class GetTransactionsByPeriodRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}