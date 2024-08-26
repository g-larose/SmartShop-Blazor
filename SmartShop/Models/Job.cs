namespace SmartShop.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobNumber { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

    }
}
