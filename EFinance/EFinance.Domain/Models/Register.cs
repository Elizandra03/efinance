namespace EFinance.Domain.Models
{
    public class Register : Entity
    {
        public DateTime OperationData { get; set; }
        public string Fund { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
