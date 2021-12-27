namespace Hostitan.API.Models
{
    public class Subscriptions
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public Guid order_id { get; set; }
        public Guid customer_id { get; set; }
        public Status Status { get; set; } = Status.active;
        public Type type { get; set; }
        public DateTime created_at { get; set; } =  DateTime.Now;
        public DateTime next_invoice_date { get; set; }
    }
}